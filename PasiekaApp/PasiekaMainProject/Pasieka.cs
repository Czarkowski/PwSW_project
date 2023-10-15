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
            var x = repository.AddUl(new UlModel { Numer = 10 });
            Console.WriteLine(x);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}