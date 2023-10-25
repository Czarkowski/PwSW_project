using Google.Protobuf.WellKnownTypes;
using PasiekaMainProject.Model;
using PasiekaMainProject.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasiekaMainProject
{
    public partial class PasiekaGrid : Form
    {
        private IPasiekaRepository repository;
        private UlModel model;
        public PasiekaGrid()
        {
            InitializeComponent();
            repository = new PasiekaRepository(MyDbContext.Instance);

        }


        private void PasiekaGrid_Load(object sender, EventArgs e)
        {

            var ulModels = repository.GetUls(); // Pobierz dane z bazy danych
            var ulModel = repository.GetUl(1);
            dataGridView.DataSource = ulModels; // Przypisz dane do DataGridView
            var x = ulModels[1].Rasa.Nazwa;

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                if (row.DataBoundItem is UlModel value)
                {
                    ChangeSelectedModel(value);
                }

            }
            else
            {
                ChangeSelectedModel();
            }
        }

        private void setModelFieldsEnable(bool isEnable)
        {
            rtbState.Enabled = isEnable;
            rtbFuture.Enabled = isEnable;
            rtbFrame.Enabled = isEnable;
            clbStan.Enabled = isEnable;
            nudGniazdo.Enabled = isEnable;
            nudNadStawka.Enabled = isEnable;
        }

        private void setCheckedForCLB(CheckedListBox clb, UlModel model)
        {
            for (int i = 0; i < clb.Items.Count; i++)
            {
                if (clbStringIndexes.TryGetValue(clb.Items[i].ToString(), out PropertyInfo prop))
                {
                    bool value = (bool?)prop.GetValue(model) ?? false;
                    clb.SetItemChecked(i, value);
                }
            }
        }


        private void btnNewUl_Click(object sender, EventArgs e)
        {
            NewHive newHive = new NewHive();
            newHive.Show();
        }

        private void btnUpdateUl_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveUl_Click(object sender, EventArgs e)
        {

        }

        #region Struct, Dict, etc:

        private struct ClbIndexesStruct
        {
            internal static readonly string Odklad = "Odkład";
            internal static readonly string NowaMatka = "Nowa Matka";
            internal static readonly string Wyrojone = "Wyrojone";
        }

        private Dictionary<string, PropertyInfo> clbStringIndexes = new Dictionary<string, PropertyInfo>
        {
            {ClbIndexesStruct.Odklad ,typeof(UlModel).GetProperty("CzyOdklad")},
            {ClbIndexesStruct.NowaMatka,typeof(UlModel).GetProperty("CzyNowaMatka") },
            {ClbIndexesStruct.Wyrojone,typeof(UlModel).GetProperty("CzyWyrojone") }
        };

        #endregion

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            setModelFieldsEnable(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.OpisStanu = rtbState.Text;
            model.OpisZaPlanowane = rtbFuture.Text;
            model.OpisRamki = rtbFrame.Text;
            model.RamkiNadStawka = (int)nudNadStawka.Value;
            model.RamkiGniazdo = (int)nudGniazdo.Value;
            model.CzyOdklad = clbStan.GetItemChecked(clbStan.FindString(ClbIndexesStruct.Odklad));
            model.CzyNowaMatka = clbStan.GetItemChecked(clbStan.FindString(ClbIndexesStruct.NowaMatka));
            model.CzyWyrojone = clbStan.GetItemChecked(clbStan.FindString(ClbIndexesStruct.Wyrojone));
            model.WiekMatki = int.Parse(lblWiekMatki.Text);
            repository.UpdateUl(model);
            ChangeSelectedModel();
        }

        private void btnChangeQueen_Click(object sender, EventArgs e)
        {
            if (model == null)
                return;

            ChagneQueen chagneQueen = new ChagneQueen();
            chagneQueen.chagneQueenEventHandler = (race, age) =>
            {
                model.RasaId = race.Id;
                model.WiekMatki = age;
                model.DataPoddaniaMatki = DateTime.Now;
                model.CzyNowaMatka = race.Id != 7;
                //model.RasaNazwa = race.Nazwa;
                model.Rasa = race;
                repository.UpdateUl(model);
                dataGridView.Refresh();
            };
            chagneQueen.Show();
        }

        private void ChangeSelectedModel(UlModel ulModel = null)
        {
            model = ulModel;
            setModelFieldsEnable(false);

            if (model != null)
            {
                btnChangeQueen.Enabled = true;
                rtbState.Text = model.OpisStanu;
                rtbFuture.Text = model.OpisZaPlanowane;
                rtbFuture.Text = model.OpisRamki;
                setCheckedForCLB(clbStan, model);
                nudGniazdo.Value = model.RamkiGniazdo;
                nudNadStawka.Value = model.RamkiNadStawka;
                lblWiekMatki.Text = (DateTime.Now.Year - model.DataPoddaniaMatki.Year + model.WiekMatki).ToString();
                lblNr.Text = model.Numer.ToString();
                dtpPrzeglad.Value = model?.DataOstatniegoPrzegladu != null ? model.DataOstatniegoPrzegladu : dtpPrzeglad.MinDate;
                dtpQueenAge.Value = model?.DataPoddaniaMatki != null ? model.DataPoddaniaMatki : dtpQueenAge.MaxDate;
            }
            else
            {
                btnChangeQueen.Enabled = false;
                rtbState.Text = default;
                rtbFuture.Text = default;
                rtbFuture.Text = default;
                for (int i = 0; i < clbStan.Items.Count; i++)
                    clbStan.SetItemChecked(i, false);
                nudGniazdo.Value = default;
                nudNadStawka.Value = default;
                lblWiekMatki.Text = default;
                lblNr.Text = default;
                dtpPrzeglad.Value = dtpPrzeglad.MinDate;
                dtpQueenAge.Value = dtpQueenAge.MaxDate;
            }


        }
    }
}

