using Data.Core.Services.Interfaces;
using MobileApp.Factories.Interfaces;

namespace MobileApp
{
    public partial class App : Application
    {
        public static IBeeService Database { get; private set; }
        public App(IBeeService beeService, IViewModelsFactories viewModelsFactories)
        {
            InitializeComponent();
            Database = beeService;  
            MainPage = new AppShell();
        }
    }
}
