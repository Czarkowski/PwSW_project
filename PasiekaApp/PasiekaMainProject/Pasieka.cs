using PasiekaMainProject.Model;
using PasiekaMainProject.Repositories;

namespace PasiekaMainProject
{
    public partial class Pasieka : Form
    {
        private readonly IPasiekaRepository repository;
        public Pasieka()
        {
            InitializeComponent();
            repository = new PasiekaRepository(MyDbContext.Instance);
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
            
            pasiekaGrid.Show();
        }
    }
}