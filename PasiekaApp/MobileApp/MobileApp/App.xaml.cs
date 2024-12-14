using Data.Core;
using Data.Core.Services.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.Localizations;
using MobileApp.UserPreferences;
using System.Resources;
using Data.Core.Models;


namespace MobileApp
{
    public partial class App : Application
    {
        public static new App Current => (App)Application.Current;
        public readonly IServiceProvider ServicesProvider;
        public readonly IServiceScopeFactory ServiceScopeFactory;
        private readonly IInitializeResources _staticResourcesServices;
        private readonly IBeeService _beeService;
        private IServiceScope _currentScope;
        public App(IInitializeResources staticResourcesServices, IServiceProvider serviceProvider, IBeeService beeService, 
            IServiceScopeFactory serviceScopeFactory)
        {
            _beeService = beeService;
            _staticResourcesServices = staticResourcesServices;
            ServicesProvider = serviceProvider;
            ServiceScopeFactory = serviceScopeFactory;

            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
            TaskScheduler.UnobservedTaskException += OnUnobservedTaskException!;

            if (true)
            {

            }
            InitializeComponent();

            InitializeData();

            InitializeMainPage();

            //SelectAndSaveImage();
        }

        public void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            LogException(e.ExceptionObject as Exception, "Unhandled Exception");
        }

        public static void OnUnhandledUiException(object sender, Exception e)
        {
            LogException(e, "Unhandled Ui Exception");
        }

        private void OnUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            LogException(e.Exception.InnerException ?? e.Exception, "Unobserved Task Exception");
            e.SetObserved();
        }


        private static void LogException(Exception ex, string exceptionType)
        {
#if DEBUG
            if (ex != null)
            {
                string filePath = @"E:\BeeApp\error_log.txt";
                File.AppendAllText(filePath, $"{DateTime.Now}: [{exceptionType}] {ex.Message}\n{ex.StackTrace}\n\n");
            }
#endif
        }

        public void ResetScope()
        {
            //ServicesProvider.GetService<BeeDbContext>();
            //if (_currentScope != null)
            //{
            //    _currentScope.Dispose();
            //    _currentScope = null;
            //}
            //_currentScope = ServiceScopeFactory.CreateScope();

            //ServicesProvider.GetService<BeeDbContext>();
            //_currentScope.Dispose();
            //ServicesProvider.GetService<BeeDbContext>();
            //_currentScope = ServicesProvider.CreateScope();
            //using (var scope = ServicesProvider.CreateScope())
            //{
            //    scope.ServiceProvider.GetService<BeeDbContext>();
            //    ServicesProvider.GetService<BeeDbContext>();
            //}
        }

        public void InitializeData()
        {
            ResetScope();
            EnsureDbInitialized();
            InitializeStaticResources();
            InitializeLocalizer();
        }

        public void InitializeMainPage()
        {
            InitializeCulture();

            MainPage = new AppShell();
        }

        private void InitializeCulture()
        {
            var languageCode = AppPreferences.Language;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(languageCode);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(languageCode);
            LocalizeManager.SetCulture(Thread.CurrentThread.CurrentUICulture);
        }

        private void EnsureDbInitialized()
        {
            BeeDbContext.EnsureInitialized();
        }

        private void InitializeLocalizer()
        {
            ResourceManager resourceManager = new ResourceManager("MobileApp.Resources.Languages.Strings", typeof(App).Assembly);
            LocalizeManager.Initialize(resourceManager);
        }

        private void InitializeStaticResources()
        {
            if (!Resources.MergedDictionaries.Contains(_staticResourcesServices.ResourceDictionary))
            {
                Resources.MergedDictionaries.Add(_staticResourcesServices.ResourceDictionary);
            }
            _staticResourcesServices.InitializeResources();
        }


        public async Task SelectAndSaveImage()
        {
            throw new NotImplementedException();
            // Wybierz plik obrazu
            //var result = await FilePicker.PickAsync(new PickOptions
            //{
            //    FileTypes = FilePickerFileType.Images // Tylko obrazy
            //});

            //if (result != null)
            //{
            //    // Ścieżka do pliku
            //    string filePath = result.FullPath;

            //    // Zapisz obraz w bazie danych
            //    await SaveImageToDatabase(filePath);
            //}
            //await SaveImageToDatabase(@"E:\ProgramingUTP\PwSW\Photos\IMG_2643.JPG");
            //await SaveImageToDatabase(@"E:\ProgramingUTP\PwSW\Photos\IMG_2647.JPG");
            //await SaveImageToDatabase(@"E:\ProgramingUTP\PwSW\Photos\IMG_2649.JPG");
            //await SaveImageToDatabase(@"E:\ProgramingUTP\PwSW\Photos\IMG_2654.JPG");
            //await SaveImageToDatabase(@"E:\ProgramingUTP\PwSW\Photos\IMG_2658.JPG");
        }
        public async Task SaveImageToDatabase(string filePath)
        {
            // Wczytaj obraz z pliku
            byte[] imageBytes = await File.ReadAllBytesAsync(filePath);

            // Utwórz nowy obiekt ImageData
            var imageData = new Photo
            { 
                DateTaken = DateTime.Now,
                DescriptionId = 13,
                ImageData = imageBytes
            };

            _beeService.AddPhoto(imageData);
        }
    }
}
