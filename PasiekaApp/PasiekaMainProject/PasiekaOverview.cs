using PasiekaMainProject.Helpers;
using PasiekaMainProject.Model;
using PasiekaMainProject.MyEnums;
using PasiekaMainProject.Repositories;
using SingletonLib;
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
    public partial class PasiekaOverview : UserControl, ISingleton<PasiekaOverview>
    {
        private IPasiekaRepository repository;

        private PrzegladModel currentPrzeglad;
        private OpisUlPrzegladModel currentUlOpis;
        private List<PrzegladModel> przegladModels;
        public PasiekaOverview()
        {
            InitializeComponent();
            repository = new PasiekaRepository(MyDbContext.Instance);
        }


        private void PasiekaOverview_Load(object sender, EventArgs e)
        {
            var enumValues = Enum.GetValues(typeof(CelEnum)).Cast<CelEnum>().ToList();
            var extEnumValues = enumValues.Select(x => new { ExtCelEnum = x, Name = x.ToString() }).ToList();
            extEnumValues.Insert(0, new { ExtCelEnum = (CelEnum)(-1), Name = "Wszystkie" });
            cbFilterCel.Items.Clear();
            cbFilterCel.DisplayMember = "Name";
            cbFilterCel.DataSource = extEnumValues;
            przegladModels = repository.GetAllPrzeglads();
            dgvPrzeglad.DataSource = przegladModels;
        }

        private void dgvPrzeglad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPrzeglad.Rows[e.RowIndex].DataBoundItem is PrzegladModel value)
            {
                ChangeSelectedPrzeglad(value);
                ChangeSelectedUlOpis();
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
                dtpDataUtworzenia.Visible = false;
                dtpDataZaPlanowana.Visible = false;
                dtpDataWykonania.Visible = false;
                dgvDescriptionUl.DataSource = default;
            }
            else
            {
                var targetModel = currentPrzeglad;
                var rowIndex = dgvPrzeglad.Rows.Cast<DataGridViewRow>()
                    .Select((row, index) => new { Row = row, Index = index })
                    .FirstOrDefault(item => item.Row.DataBoundItem == targetModel)?.Index;

                if (rowIndex.HasValue)
                {
                    dgvPrzeglad.ClearSelection();
                    dgvPrzeglad.Rows[rowIndex.Value].Selected = true;
                }

                dtpDataUtworzenia.Visible = true;
                dtpDataZaPlanowana.Visible = true;
                dtpDataWykonania.Visible = true;
                lblCel.Text = currentPrzeglad.Cel;
                lblPrzegladId.Text = currentPrzeglad.Id.ToString();
                tbOpis.Text = currentPrzeglad.Opis;
                dtpDataUtworzenia.Value = UsefulMethods.MaxDate(SpecialValues.MinDateTime, currentPrzeglad.DataUtworzenia);
                dtpDataZaPlanowana.Value = UsefulMethods.MaxDate(SpecialValues.MinDateTime, currentPrzeglad.DataZaplanowana);
                dtpDataWykonania.Value = UsefulMethods.MaxDate(SpecialValues.MinDateTime, currentPrzeglad.DataWykonania ?? DateTime.MinValue);
                dtpDataWykonania.Visible = dtpDataWykonania.Value > SpecialValues.MinDateTime;
                dgvDescriptionUl.DataSource = currentPrzeglad.OpisUlPrzegladModels;
            }
            btnUpdate.Enabled = currentPrzeglad != null;
            btnDelete.Enabled = currentPrzeglad != null;
            btnForce.Enabled = currentPrzeglad != null;
            dgvPrzeglad.Refresh();
            ChangeSelectedUlOpis();
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
                lblSelectedUl.Text = $"Przegląd \"{currentPrzeglad.Cel}\", Zaplanowany na: {currentPrzeglad.DataZaplanowana.ToString("dd.MM.yyyy")}, dla ula Nr: {currentUlOpis.Numer}";
            }
            setEnableBtnComplete(currentUlOpis != null && (currentUlOpis.DataPrzegladu == null || currentUlOpis.DataPrzegladu.Value <= SpecialValues.MinDateTime));
            dgvDescriptionUl.Refresh();
        }

        private void setEnableBtnComplete(bool isEnable = true)
        {
            btnComplete.Enabled = isEnable;
            tbOpisUl.Enabled = isEnable;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (currentUlOpis != null && currentPrzeglad != null)
            {
                currentUlOpis.Opis = tbOpisUl.Text ?? string.Empty;
                currentUlOpis.DataPrzegladu = DateTime.Now;
                repository.UpdateOpisUlPrzeglad(currentUlOpis);
                dgvDescriptionUl.Refresh();
                if (UsefulMethods.IsAllOverviewComplete(currentPrzeglad.OpisUlPrzegladModels))
                {
                    currentPrzeglad.DataWykonania = DateTime.Now;
                    repository.UpdatePrzeglad(currentPrzeglad);
                    dgvPrzeglad.Refresh();
                    ChangeSelectedPrzeglad(currentPrzeglad);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewOverview newOverview = new NewOverview();

            DialogResult dialogResult = newOverview.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                przegladModels = repository.GetAllPrzeglads();
                filterDgvPrzeglad(((dynamic)cbFilterCel.SelectedItem).ExtCelEnum, chFilterNotDone.Checked);
                ChangeSelectedPrzeglad(newOverview.NewPrzeglad);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (currentPrzeglad.IsNull())
            {
                return;
            }
            if (currentPrzeglad.IsCompleted || currentPrzeglad.OpisUlPrzegladModels.Any(x => x.IsCompleted))
            {
                MessageBox.Show("Nie można już edytować tego przeglądu", "Bład!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NewOverview editOverview = new NewOverview();
            editOverview.Text = "Edycja";
            editOverview.IsEditMode = true;
            editOverview.EditedPrzeglad = currentPrzeglad;
            DialogResult dialogResult = editOverview.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                przegladModels = repository.GetAllPrzeglads();
                filterDgvPrzeglad(((dynamic)cbFilterCel.SelectedItem).ExtCelEnum, chFilterNotDone.Checked);
                ChangeSelectedPrzeglad(currentPrzeglad);
            }
        }

        private void chFilterIsDone_CheckedChanged(object sender, EventArgs e)
        {
            filterDgvPrzeglad(((dynamic)cbFilterCel.SelectedItem).ExtCelEnum, chFilterNotDone.Checked);
        }

        private void cbFilterCel_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterDgvPrzeglad(((dynamic)cbFilterCel.SelectedItem).ExtCelEnum, chFilterNotDone.Checked);
        }

        private void filterDgvPrzeglad(CelEnum cel, bool NotDone)
        {
            dgvPrzeglad.DataSource = przegladModels?.Where(x => (cel != (CelEnum)(-1) ? x.CelEnum == cel : true) && (NotDone ? !x.IsCompleted : true)).ToList();
        }

        private void btnForce_Click(object sender, EventArgs e)
        {
            if (currentPrzeglad != null)
            {
                DialogResult result = MessageBox.Show($"Czy na pewno chcesz zakonczyć przeglad nr: {currentPrzeglad.Id}?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    currentPrzeglad.OpisUlPrzegladModels.ForEach(x =>
                    {
                        if (!x.IsCompleted)
                        {
                            x.Opis = "Wymuszono Zakonczenie";
                            x.DataPrzegladu = DateTime.Now;
                            repository.UpdateOpisUlPrzeglad(x);
                        }
                    });
                    if (UsefulMethods.IsAllOverviewComplete(currentPrzeglad.OpisUlPrzegladModels))
                    {
                        currentPrzeglad.DataWykonania = DateTime.Now;
                        repository.UpdatePrzeglad(currentPrzeglad);
                        dgvPrzeglad.Refresh();
                        ChangeSelectedPrzeglad(currentPrzeglad);
                    }
                }
                else
                {

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentPrzeglad != null)
            {
                DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć przeglad nr: {currentPrzeglad.Id}?", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    repository.DeletePrzeglad(currentPrzeglad);
                    przegladModels = repository.GetAllPrzeglads();
                    filterDgvPrzeglad(((dynamic)cbFilterCel.SelectedItem).ExtCelEnum, chFilterNotDone.Checked);
                    ChangeSelectedPrzeglad();
                }
                else
                {

                }
            }
        }

        static PasiekaOverview ISingleton<PasiekaOverview>.initilize()
        {
            return new();
        }
    }
}
