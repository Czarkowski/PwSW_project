﻿using PasiekaMainProject.Helpers;
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
    public partial class NewOverview : Form
    {
        IPasiekaRepository repository;
        List<UlModel> availableUl = new List<UlModel>();
        List<UlModel> selectedUl = new List<UlModel>();
        public NewOverview()
        {
            InitializeComponent();
            repository = new PasiekaRepository(MyDbContext.Instance);
        }

        private void NewOverview_Load(object sender, EventArgs e)
        {
            cbCelEnum.Items.Clear();
            cbCelEnum.DataSource = Enum.GetValues(typeof(CelEnum)).Cast<CelEnum>().ToList();
            availableUl = new List<UlModel>(repository.GetUls()).OrderBy(x => x.Numer).ToList();
            dgvAvailable.DataSource = new List<UlModel>(availableUl);
            dgvSelected.DataSource = new List<UlModel>(selectedUl);
            //dgvAvailable.Sort(dgvAvailable.Columns[0], ListSortDirection.Ascending);

        }

        private void dgvAvailable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAvailable.Rows[e.RowIndex].DataBoundItem is UlModel value)
            {

                selectedUl.Add(value);
                availableUl.Remove(value);
                refreshDGV();
            }
            else
            {
            }
        }

        private void dgvSelected_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSelected.Rows[e.RowIndex].DataBoundItem is UlModel value)
            {
                availableUl.Add(value);
                selectedUl.Remove(value);
                refreshDGV();
            }
            else
            {
            }
        }
        private void refreshDGV()
        {
            //availableUl.Sort(UsefulMethods.UlComparator);
            //selectedUl.Sort(UsefulMethods.UlComparator);
            dgvAvailable.DataSource = new List<UlModel>(availableUl);
            dgvSelected.DataSource = new List<UlModel>(selectedUl);
            ((List<UlModel>)dgvAvailable.DataSource).Sort(UsefulMethods.UlComparator);
            ((List<UlModel>)dgvSelected.DataSource).Sort(UsefulMethods.UlComparator);
            dgvAvailable.Refresh();
            dgvSelected.Refresh();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var overview = new PrzegladModel();
            overview.DataZaPlanowana = dtpDate.Value;
            overview.DataUtworzenia = DateTime.Now;
            overview.Cel = tbCel.Text;
            overview.CelEnum = (int)cbCelEnum.SelectedItem;
            overview.Opis = rtbOpis.Text;
            var opisUlPrzegladModels = new List<OpisUlPrzegladModel>();
            var selected = (List<UlModel>)dgvSelected.DataSource;
            selected.ForEach(o =>
            {
                var oupm = new OpisUlPrzegladModel();
                oupm.UlId = o.Id;
                opisUlPrzegladModels.Add(oupm);
            });
            overview.OpisUlPrzegladModels = opisUlPrzegladModels;
            repository.SavePrzeglad(overview);
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}