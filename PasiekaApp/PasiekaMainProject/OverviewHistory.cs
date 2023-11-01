using PasiekaMainProject.Helpers;
using PasiekaMainProject.Model;
using PasiekaMainProject.MyEnums;
using PasiekaMainProject.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasiekaMainProject
{
    public partial class OverviewHistory : Form
    {
        private IPasiekaRepository repository;
        private UlModel _model;
        private OpisUlPrzegladModel _currentOpisUlPrzeglad;
        private List<OpisUlPrzegladModel> _dataSource;
        //private List<DataGridViewRow> _rows = new List<DataGridViewRow>();
        public OverviewHistory(UlModel model)
        {
            InitializeComponent();
            repository = new PasiekaRepository(MyDbContext.Instance);
            _model = model;
        }

        private void OverviewHistory_Load(object sender, EventArgs e)
        {
            _dataSource = repository.GetOpisUlPrzegladsWithPrzeglad(_model);
            dgvOverview.DataSource = _dataSource;
            //DataGridViewColumn customColumnCel = new DataGridViewTextBoxColumn();
            //customColumnCel.HeaderText = "CelEnum";
            //customColumnCel.Name = "CelEnum";
            //DataGridViewColumn customColumnDate = new DataGridViewTextBoxColumn();
            //customColumnDate.HeaderText = "Data Zaplanowana";
            //customColumnDate.Name = "Data";
            //dgvOverview.Columns.Add(customColumnDate);
            //dgvOverview.Columns.Add(customColumnCel);
            //foreach (DataGridViewRow row in dgvOverview.Rows)
            //{
            //    OpisUlPrzegladModel model = (OpisUlPrzegladModel)row.DataBoundItem;
            //    row.Cells[customColumnCel.Index].Value = model.Przeglad.CelEnum;
            //    row.Cells[customColumnDate.Index].Value = model.Przeglad.DataZaplanowana;
            //}

            var enumValues = Enum.GetValues(typeof(CelEnum)).Cast<CelEnum>().ToList();
            var extEnumValues = enumValues.Select(x => new { ExtCelEnum = x, Name = x.ToString() }).ToList();
            extEnumValues.Insert(0, new { ExtCelEnum = (CelEnum)(-1), Name = "Wszystkie" });
            cbFilterCel.Items.Clear();
            cbFilterCel.DisplayMember = "Name";
            cbFilterCel.DataSource = extEnumValues;
            lblMain.Text = $"Historia przeglądów dla Ul nr : {_model.Numer}";
        }

        private void cbFilterCel_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterDgvPrzeglad(((dynamic)cbFilterCel.SelectedItem).ExtCelEnum, chFilterNotDone.Checked);
        }

        private void chFilterNotDone_CheckedChanged(object sender, EventArgs e)
        {
            filterDgvPrzeglad(((dynamic)cbFilterCel.SelectedItem).ExtCelEnum, chFilterNotDone.Checked);
        }

        private void dgvOverview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvOverview.Rows[e.RowIndex].DataBoundItem is OpisUlPrzegladModel value)
            {
                ChangeSelectedUlOpisPrzeglad(value);
            }
            else
            {
                ChangeSelectedUlOpisPrzeglad();
            }
        }

        private void ChangeSelectedUlOpisPrzeglad(OpisUlPrzegladModel model = null)
        {
            _currentOpisUlPrzeglad = model;
            if (_currentOpisUlPrzeglad == null)
            {
                lblCel.Text = default;
                lblPrzegladId.Text = default;
                dtpDataUtworzenia.Value = SpecialValues.MinDateTime;
                dtpDataZaPlanowana.Value = SpecialValues.MinDateTime;
                dtpDataWykonania.Value = SpecialValues.MinDateTime;
                dtpDataUtworzenia.Visible = false;
                dtpDataZaPlanowana.Visible = false;
                dtpDataWykonania.Visible = false;
                tbPrzegldOpis.Text = default;
                tbUlOpis.Text = default;
            }
            else
            {

                dtpDataUtworzenia.Visible = true;
                dtpDataZaPlanowana.Visible = true;
                dtpDataWykonania.Visible = true;
                lblCel.Text = _currentOpisUlPrzeglad.Przeglad.Cel;
                lblPrzegladId.Text = _currentOpisUlPrzeglad.Przeglad.Id.ToString();
                tbUlOpis.Text = _currentOpisUlPrzeglad.Opis;
                tbPrzegldOpis.Text = _currentOpisUlPrzeglad.Przeglad.Opis;
                dtpDataUtworzenia.Value = UsefulMethods.MaxDate(SpecialValues.MinDateTime, _currentOpisUlPrzeglad.Przeglad.DataUtworzenia);
                dtpDataZaPlanowana.Value = UsefulMethods.MaxDate(SpecialValues.MinDateTime, _currentOpisUlPrzeglad.Przeglad.DataZaplanowana);
                dtpDataWykonania.Value = UsefulMethods.MaxDate(SpecialValues.MinDateTime, _currentOpisUlPrzeglad.DataPrzegladu ?? DateTime.MinValue);
                dtpDataWykonania.Visible = dtpDataWykonania.Value > SpecialValues.MinDateTime;
            }
        }

        private void filterDgvPrzeglad(CelEnum cel, bool NotDone)
        {
            dgvOverview.DataSource = _dataSource.Where(x => (cel != (CelEnum)(-1) ? x.CelEnum == cel : true) && (NotDone ? !x.IsCompleted : true)).ToList();
        }

    }
}
