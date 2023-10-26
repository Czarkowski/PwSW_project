using PasiekaMainProject.Helpers;
using PasiekaMainProject.Model;
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
    public partial class PasiekaOverview : Form
    {
        private IPasiekaRepository repository;

        private PrzegladModel currentPrzeglad;
        private OpisUlPrzegladModel currentUlOpis;
        public PasiekaOverview()
        {
            InitializeComponent();
            repository = new PasiekaRepository(MyDbContext.Instance);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewOverview newOverview = new NewOverview();

            newOverview.Show();
        }

        private void PasiekaOverview_Load(object sender, EventArgs e)
        {
            dgvPrzeglad.DataSource = repository.GetAllPrzeglads();
        }

        private void dgvPrzeglad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPrzeglad.Rows[e.RowIndex].DataBoundItem is PrzegladModel value)
            {
                ChangeSelectedPrzeglad(value);
            }
            else
            {
                ChangeSelectedPrzeglad();
                ChangeSelectedUlOpis();
            }
        }



        private void dgvDescriptionUl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDescriptionUl.Rows[e.RowIndex].DataBoundItem is OpisUlPrzegladModel value)
            {
                ChangeSelectedUlOpis(value);
            }
            else
            {
                ChangeSelectedUlOpis();
            }
        }

        private void ChangeSelectedPrzeglad(PrzegladModel model = null)
        {
            currentPrzeglad = model;
            if (currentPrzeglad == null)
            {
                lblCel.Text = default;
                lblPrzegladId.Text = default;
                tbOpis.Text = default;
                dtpDataUtworzenia.Value = SpecialValues.MinDateTime;
                dtpDataZaPlanowana.Value = SpecialValues.MinDateTime;
                dtpDataWykonania.Value = SpecialValues.MinDateTime;
                dgvDescriptionUl.DataSource = default;
            }
            else
            {
                lblCel.Text = currentPrzeglad.Cel;
                lblPrzegladId.Text = currentPrzeglad.Id.ToString();
                tbOpis.Text = currentPrzeglad.Opis;
                dtpDataUtworzenia.Value = UsefulMethods.MaxDate(SpecialValues.MinDateTime, currentPrzeglad.DataUtworzenia);
                dtpDataZaPlanowana.Value = UsefulMethods.MaxDate(SpecialValues.MinDateTime, currentPrzeglad.DataZaPlanowana);
                dtpDataWykonania.Value = UsefulMethods.MaxDate(SpecialValues.MinDateTime, currentPrzeglad.DataWykonania ?? DateTime.MinValue);
                dgvDescriptionUl.DataSource = currentPrzeglad.OpisUlPrzegladModels;
            }
            btnUpdate.Enabled = currentPrzeglad != null;
        }

        private void ChangeSelectedUlOpis(OpisUlPrzegladModel model = null)
        {
            currentUlOpis = model;
            if (currentUlOpis == null)
            {
                tbOpisUl.Text = default;
                lblSelectedUl.Text = default;
            }
            else
            {
                tbOpisUl.Text = currentUlOpis.Opis;
                lblSelectedUl.Text = $"Przegląd \"{currentPrzeglad.Cel}\", Zaplanowany na: {currentPrzeglad.DataZaPlanowana.ToString("dd.MM.yyyy")}, dla ula Nr: {currentUlOpis.Numer}";
            }
            setEnableBtnComplete(currentUlOpis != null && (currentUlOpis.DataPrzegladu == null || currentUlOpis.DataPrzegladu.Value <= SpecialValues.MinDateTime));
        }

        private void setEnableBtnComplete(bool isEnable = true)
        {
            btnComplete.Enabled = isEnable;
            tbOpisUl.Enabled = isEnable;
        }
    }
}
