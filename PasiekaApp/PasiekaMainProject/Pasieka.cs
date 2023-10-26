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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var x = repository.AddUl(new UlModel { Numer = 12 });
            Console.WriteLine(x);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var x = repository.GetUls();
            x.ForEach(x => { Console.WriteLine(x.Id); });

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
                btnAdd, btnRemove, btnShow, btnPrzeglady
            };
            foreach (Button item in buttons)
            //foreach (Control item in Controls["tableLayoutPanel1"]?.Controls["tableLayoutPanel2"]?.Controls)
            {
                if (item is Button btn)
                {
                    btn.Enabled = !btn.Equals(button);
                }
            }
        }
    }
}