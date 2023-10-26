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
        public delegate void ChagneQueenEventHandler(RasaModel race, int age, DateTime data);
        private static RasaModel defaultValueForcbRace => RasaModel.GetPlaceHolder("");

        public ChagneQueenEventHandler chagneQueenEventHandler { get; set; }
        public ChagneQueen()
        {
            InitializeComponent();
            repository = new PasiekaRepository(MyDbContext.Instance);
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbRace.SelectedValue != null && !cbRace.SelectedValue.Equals(defaultValueForcbRace.Id))
            {
                chagneQueenEventHandler?.Invoke((RasaModel)cbRace.SelectedItem, (int)nudAge.Value, dtpDate.Value);
                Close();
            }
        }

        private void ChagneQueen_Load(object sender, EventArgs e)
        {
            var ds = repository.GetAllRasas();
            ds.RemoveAll(x => x.Nazwa.Contains("test", StringComparison.OrdinalIgnoreCase));
            ds.Add(defaultValueForcbRace);
            cbRace.DataSource = ds.OrderBy(x => x.Id).ToList();
            dtpDate.Value = DateTime.Now;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRace.SelectedValue != null && cbRace.SelectedItem is RasaModel rasa)
            {
                pb1.Value = rasa.Rojliwosc * 10;
                pb2.Value = rasa.Lagodnosc * 10;
                pb3.Value = rasa.Produktywnosc * 10;
                pb4.Value = rasa.Higienicznosc * 10;
                pb5.Value = rasa.Licznosc * 10;
            }
        }
    }
}
