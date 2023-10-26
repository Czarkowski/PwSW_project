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
            dgvPrzeglad.DataSource = repository.GetAllPrzedlads();
        }
    }
}
