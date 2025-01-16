using Data.Core.Services.Interfaces;
using MobileApp.Core.BasePages;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.ViewModels;

namespace MobileApp.Pages;

public partial class ApiaryProductionSummaryMainPage : BaseContentPage<ApiaryProductionSummaryMainVM>
{
    private readonly IBeeService _beeService;
    private readonly IViewModelsFactory _viewModelsFactory;
    private readonly IDataToSaveFactory _dataToSaveFactory;
    private readonly IApiaryToolHelper _apiaryToolHelper;
    private readonly IPickerItemFactory _pickerItemFactory;
    public ApiaryProductionSummaryMainPage(IBeeService beeService, IViewModelsFactory viewModelsFactory,
        IDataToSaveFactory dataToSaveFactory, IApiaryToolHelper apiaryToolHelper, IPickerItemFactory pickerItemFactories)
	{
        _beeService = beeService;
        _viewModelsFactory = viewModelsFactory;
        _dataToSaveFactory = dataToSaveFactory;
        _apiaryToolHelper = apiaryToolHelper;
        _pickerItemFactory = pickerItemFactories;
        InitializeComponent();
	}

    protected override void LoadData()
    {
        var productions = _beeService.GetProductions();
        ViewModel = _viewModelsFactory.CreateApiaryProductionSummaryMainVM(productions);
    }
    protected override void OnAppearing()
    {
        LoadData();
    }
}