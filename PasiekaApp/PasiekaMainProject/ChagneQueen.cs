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
    public partial class ChagneQueen : Form
    {
        IPasiekaRepository repository;
        public delegate void ChagneQueenEventHandler(RasaModel race, int age);
        private static RasaModel defaultValueForcbRace => RasaModel.GetPlaceHolder("");

        public ChagneQueenEventHandler chagneQueenEventHandler { get; set; }
        public ChagneQueen()
        {
            InitializeComponent();
            repository = new PasiekaRepository(MyDbContext.Instance);
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!cbRace.SelectedValue.Equals(defaultValueForcbRace.Id))
            {
                chagneQueenEventHandler?.Invoke((RasaModel)cbRace.SelectedItem, (int)nudAge.Value);
                Close();
            }
        }

        private void ChagneQueen_Load(object sender, EventArgs e)
        {
            var ds = repository.GetAllRasas();
            ds.RemoveAll(x => x.Nazwa.Contains("test", StringComparison.OrdinalIgnoreCase));
            ds.Add(defaultValueForcbRace);
            cbRace.DataSource = ds.OrderBy(x => x.Id).ToList();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
