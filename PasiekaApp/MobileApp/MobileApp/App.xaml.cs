using Data.Core;
using System.Xml.Linq;

namespace MobileApp
{
    public partial class App : Application
    {
        public App(IBeeService beeService)
        {
            InitializeComponent();
            //DependencyService.Get<IBeeService>().Get();
            MainPage = new AppShell();
        }
    }
}
