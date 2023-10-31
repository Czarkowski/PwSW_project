using PasiekaMainProject.Model;
using PasiekaMainProject.MyClassAndInterface;
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
    public partial class QueenCalc : UserControl, IRefreshCalcUserControl
    {
        IPasiekaRepository repository;
        public QueenCalc()
        {
            InitializeComponent();
            repository = new PasiekaRepository(MyDbContext.Instance);
        }

        public void RefreshCalc()
        {
        }

        private void QueenCalc_Load(object sender, EventArgs e)
        {
            ListView listView = lvMain;
            listView.View = View.Details;

            listView.Columns.Add("Rasa", 150);
            listView.Columns.Add("Do Wymiany [szt.]", 200);

            List<RasaModel> rasaModels = repository.GetAllRasas().Where(x => !x.Nazwa.Contains("test", StringComparison.OrdinalIgnoreCase)).ToList();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<UlModel> ulModels = repository.GetUls();


            rasaModels.ForEach(rasaModel =>
            {
                int val = ulModels.Where(x => x.RasaId == rasaModel.Id && x.GetRelQueenAge() >= 2).Count();
                dict.Add(rasaModel.Nazwa, val);
            });

            foreach (var d in dict)
            {
                ListViewItem item = new ListViewItem(d.Key);
                item.SubItems.Add(d.Value.ToString());
                listView.Items.Add(item);
            }

        }
    }
}
