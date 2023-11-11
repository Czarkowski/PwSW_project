using PasiekaMainProject.Model;
using PasiekaMainProject.MyClassAndInterface;
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
            PasiekaCalculator pasiekaCalculator = SingletonPasiekaCalculator.Instance;
            Panel panel = panelMain;
            panel.Controls.Clear();
            panel.Controls.Add(pasiekaCalculator);
            enableOtherButton(sender as Button);
            pasiekaCalculator.Location = new Point(0, 0);
            lblMain.Text = "Klakulator Pasieczny";
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            PasiekaMap pasiekaMap = SingletonPasiekaMap.Instance;
            Panel panel = panelMain;
            panel.Controls.Clear();
            panel.Controls.Add(pasiekaMap);
            enableOtherButton(sender as Button);
            pasiekaMap.RefreshSingletonControls();
            pasiekaMap.Location = new Point(0, 0);
            lblMain.Text = "Interaktywna mapa Pasieki";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            PasiekaGrid pasiekaGrid = SingletonPasiekaGrid.Instance;
            Panel panel = panelMain;
            panel.Controls.Clear();
            panel.Controls.Add(pasiekaGrid);
            enableOtherButton(sender as Button);
            pasiekaGrid.Location = new Point(0, 0); 
            lblMain.Text = "Stan Pasieki";
        }

        private void btnPrzeglady_Click(object sender, EventArgs e)
        {
            PasiekaOverview pasiekaOverview = SingletonPasiekaOverview.Instance;
            Panel panel = panelMain;
            panel.Controls.Clear();
            panel.Controls.Add(pasiekaOverview);
            enableOtherButton(sender as Button);
            pasiekaOverview.Location = new Point(0, 0);
            lblMain.Text = "Planowanie i zarz¹dzanie przegl¹dami";
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