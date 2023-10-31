using PasiekaMainProject.Model;
using PasiekaMainProject.Repositories;
using System.Windows.Forms;

namespace PasiekaMainProject
{
    public partial class Pasieka : Form
    {
        private readonly IPasiekaRepository repository;
        public Pasieka()
        {
            InitializeComponent();
            repository = new PasiekaRepository(MyDbContext.Instance);
            var x = repository.GetRasa("Test");
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            PasiekaCalculator pasiekaCalculator = new PasiekaCalculator();

            Panel panel = panelMain;

            panel.Controls.Clear();

            panel.Controls.Add(pasiekaCalculator);

            enableOtherButton(sender as Button);
        }

        private void btnMap_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            PasiekaGrid pasiekaGrid = new PasiekaGrid();

            Panel panel = panelMain;

            panel.Controls.Clear();

            panel.Controls.Add(pasiekaGrid);

            enableOtherButton(sender as Button);
        }

        private void btnPrzeglady_Click(object sender, EventArgs e)
        {
            PasiekaOverview pasiekaOverview = new PasiekaOverview();

            Panel panel = panelMain;

            panel.Controls.Clear();

            panel.Controls.Add(pasiekaOverview);

            enableOtherButton(sender as Button);
        }

        private void enableOtherButton(Button button)
        {
            List<Button> buttons = new List<Button>
            {
                btnCalculator, btnMap, btnShow, btnPrzeglady
            };
            foreach (Button item in buttons)
            {
                if (item is Button btn)
                {
                    btn.Enabled = !btn.Equals(button);
                }
            }
        }



    }
}