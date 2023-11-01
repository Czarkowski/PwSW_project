using Google.Protobuf.WellKnownTypes;
using PasiekaMainProject.Helpers;
using PasiekaMainProject.Model;
using PasiekaMainProject.Repositories;
using SingletonLib;
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
    public partial class PasiekaGrid : UserControl, IObservable<UlModel>, ISingleton<PasiekaGrid>
    {
        private readonly HashSet<IObserver<UlModel>> _observers = new();
        private IPasiekaRepository repository;
        private UlModel _model;
        private UlModel model
        {
            get => _model;
            set
            {
                _model = value;
                foreach (var item in _observers)
                {
                    item.OnNext(model);
                }
            }
        }
        private bool IsModelSelected => model != null;
        public Delegate SelectedModelChangedEventHandler;
        public PasiekaGrid()
        {
            InitializeComponent();
            repository = new PasiekaRepository(MyDbContext.Instance);

        }


        private void PasiekaGrid_Load(object sender, EventArgs e)
        {

            var ulModels = repository.GetUls(); // Pobierz dane z bazy danych
            dataGridView.DataSource = ulModels.OrderBy(x => x.Numer).ToList();
            clbStan.Items.Clear();

            FieldInfo[] fields = typeof(ClbIndexesStruct).GetFields(BindingFlags.Public | BindingFlags.Static);
            string[] values = new string[fields.Length];

            for (int i = 0; i < fields.Length; i++)
            {
                values[i] = (string)fields[i].GetValue(null);
                clbStan.Items.Add(values[i]);
            }

            //BindingList<UlModel> bindingList = new BindingList<UlModel>(ulModels);
            //BindingSource bindingSource = new BindingSource(bindingList, null);
            //dataGridView.DataSource = bindingSource;
            //dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);

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
                    bool value = (bool?)prop?.GetValue(model) ?? false;
                    clb.SetItemChecked(i, value);
                }
            }
        }


        private void btnNewUl_Click(object sender, EventArgs e)
        {
            NewHive newHive = new NewHive();
            newHive.refreshPasiekaGrid = () => refreshDGV();
            newHive.ShowDialog();
        }

        private void btnRemoveUl_Click(object sender, EventArgs e)
        {
            if (IsModelSelected)
            {
                DialogResult result = MessageBox.Show($"Czy na pewno chcesz Usunąć ul nr: {model.Numer}?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    repository.DeleteUl(model);
                    refreshDGV();
                    ChangeSelectedModel();
                }
                else
                {

                }
            }
        }

        #region Struct, Dict, etc:

        private Dictionary<string, PropertyInfo> clbStringIndexes = new Dictionary<string, PropertyInfo>
        {
            {ClbIndexesStruct.Odklad ,typeof(UlModel).GetPropertyByDescription(ClbIndexesStruct.Odklad)},
            {ClbIndexesStruct.NowaMatka,typeof(UlModel).GetPropertyByDescription(ClbIndexesStruct.NowaMatka)},
            {ClbIndexesStruct.Wyrojone,typeof(UlModel).GetPropertyByDescription(ClbIndexesStruct.Wyrojone)}
        };

        #endregion

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            setModelFieldsEnable(true);
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            if (model.IsNull()) { return; }
            model.OpisStanu = rtbState.Text;
            model.OpisZaplanowane = rtbFuture.Text;
            model.OpisRamki = rtbFrame.Text;
            model.RamkiNadStawka = (int)nudNadStawka.Value;
            model.RamkiGniazdo = (int)nudGniazdo.Value;
            model.CzyOdklad = clbStan.GetItemChecked(clbStan.FindString(ClbIndexesStruct.Odklad));
            model.CzyNowaMatka = clbStan.GetItemChecked(clbStan.FindString(ClbIndexesStruct.NowaMatka));
            model.CzyWyrojone = clbStan.GetItemChecked(clbStan.FindString(ClbIndexesStruct.Wyrojone));
            model.WiekMatki = int.Parse(lblWiekMatki.Text);
            repository.UpdateUl(model);
            setModelFieldsEnable(false);
            //ChangeSelectedModel();
        }

        private void btnChangeQueen_Click(object sender, EventArgs e)
        {
            if (model == null)
                return;

            ChagneQueen chagneQueen = new ChagneQueen();
            chagneQueen.chagneQueenEventHandler = (race, age, date) =>
            {
                model.RasaId = race.Id;
                model.WiekMatki = age;
                model.DataPoddaniaMatki = DateTime.Now;
                model.CzyNowaMatka = race.Id != 7;
                //model.RasaNazwa = race.Nazwa;
                model.Rasa = race;
                model.DataPoddaniaMatki = date;
                repository.UpdateUl(model);
                dataGridView.Refresh();
            };
            DialogResult dialogResult = chagneQueen.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ChangeSelectedModel(model);
            }
        }

        public void ChangeSelectedModel(int id)
        {
            ChangeSelectedModel((dataGridView.DataSource as List<UlModel>).Find(x => x.Id == id));
        }
        public void ChangeSelectedModel(UlModel? ulModel = null)
        {
            model = ulModel;
            setModelFieldsEnable(false);

            if (model != null)
            {
                btnChangeQueen.Enabled = true;
                rtbState.Text = model.OpisStanu;
                rtbFuture.Text = model.OpisZaplanowane;
                rtbFrame.Text = model.OpisRamki;
                setCheckedForCLB(clbStan, model);
                nudGniazdo.Value = model.RamkiGniazdo;
                nudNadStawka.Value = model.RamkiNadStawka;
                lblWiekMatki.Text = (DateTime.Now.Year - model.DataPoddaniaMatki.Year + model.WiekMatki).ToString();
                lblNr.Text = model.Numer.ToString();
                lblRaceName.Text = model.Rasa.Nazwa;
                dtpPrzeglad.Value = model.GetDataOstatniegoPrzegladu() ?? SpecialValues.MinDateTime;
                dtpPrzeglad.Visible = dtpPrzeglad.Value > SpecialValues.MinDateTime;
                dtpQueenAge.Value = model.DataPoddaniaMatki >= SpecialValues.MinDateTime ? model.DataPoddaniaMatki : dtpQueenAge.MinDate;
                dtpQueenAge.Visible = dtpQueenAge.Value > SpecialValues.MinDateTime;
                btnRemoveUl.Enabled = true;
                btnSave.Enabled = false;
                btnShowHistory.Enabled = true;

                var targetModel = model;
                var rowIndex = dataGridView.Rows.Cast<DataGridViewRow>()
                    .Select((row, index) => new { Row = row, Index = index })
                    .FirstOrDefault(item => item.Row.DataBoundItem == targetModel)?.Index;

                if (rowIndex.HasValue)
                {
                    dataGridView.ClearSelection();
                    dataGridView.Rows[rowIndex.Value].Selected = true;
                }

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
                lblRaceName.Text = default;
                dtpPrzeglad.Value = dtpPrzeglad.MinDate;
                dtpQueenAge.Value = dtpQueenAge.MinDate;
                btnRemoveUl.Enabled = false;
                btnSave.Enabled = false;
                btnShowHistory.Enabled = false;
                dataGridView.ClearSelection();
            }
        }

        private void refreshDGV()
        {
            var ulModels = repository.GetUls(); // Pobierz dane z bazy danych
            dataGridView.DataSource = ulModels.OrderBy(x => x.Numer).ToList();
        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            if (model.IsNull()) return;
            OverviewHistory overviewHistory = new OverviewHistory(model);
            overviewHistory.ShowDialog();
        }

        public IDisposable Subscribe(IObserver<UlModel> observer)
        {
            _observers.Add(observer);
            return new Unsubscriber(() => _observers.Remove(observer));
        }

        static PasiekaGrid ISingleton<PasiekaGrid>.initilize()
        {
            return new();
        }

        private class Unsubscriber : IDisposable
        {
            private readonly Action action;
            public Unsubscriber(Action action)
            {
                this.action = action;
            }
            public void Dispose()
            {
                action();
            }
        }
    }
    public struct ClbIndexesStruct
    {
        public const string Odklad = "Odkład";
        public const string NowaMatka = "Nowa Matka";
        public const string Wyrojone = "Wyrojone";
    }
}

