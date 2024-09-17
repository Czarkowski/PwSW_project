using Data.Core.Services.Interfaces;
using MobileApp.Core.BasePages;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.ViewModels;
using System.Windows.Input;
using System.Xml.Serialization;

namespace MobileApp.Pages;

public partial class ApiaryToolSyrupCalculatorMainPage : BaseContentPage<ApiaryToolSyrupCalculatorMainVM>
{
    public ICommand OnEdit { get; set; }
    private readonly IBeeService _beeService;
    private readonly IViewModelsFactory _viewModelsFactory;
    private readonly IDataToSaveFactory _dataToSaveFactory;
    private readonly IApiaryToolHelper _apiaryToolHelper;
    public ApiaryToolSyrupCalculatorMainPage(IBeeService beeService, IViewModelsFactory viewModelsFactory,
        IDataToSaveFactory dataToSaveFactory, IApiaryToolHelper apiaryToolHelper)
    {
        _beeService = beeService;
        _viewModelsFactory = viewModelsFactory;
        _dataToSaveFactory = dataToSaveFactory;
        _apiaryToolHelper = apiaryToolHelper;
        InitializeComponent();
	}

    private void LoadData()
    {
        ViewModel = _viewModelsFactory.CreateApiaryToolSyrupCalculatorMainVM();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}