using PasiekaMainProject.Model;
using PasiekaMainProject.Repositories;
using System.ComponentModel.Design;

namespace PasiekaMainProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if (!MyDbContext.Instance.Database.CanConnect())
                throw new Exception("Nie uda�o po�aczy� si� z baz� danych");


            Application.Run(new Pasieka());
        }
    }
}