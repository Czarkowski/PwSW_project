using Data.Core.Services.Interfaces;
using MobileApp.ApiaryTools;
using MobileApp.Core.BasePages;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.ViewModels;
using MobileApp.ViewModels.PickerItems.Base;
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
    private readonly IPickerItemFactories _pickerItemFactories;
    public ApiaryToolSyrupCalculatorMainPage(IBeeService beeService, IViewModelsFactory viewModelsFactory,
        IDataToSaveFactory dataToSaveFactory, IApiaryToolHelper apiaryToolHelper, IPickerItemFactories pickerItemFactories)
    {
        _beeService = beeService;
        _viewModelsFactory = viewModelsFactory;
        _dataToSaveFactory = dataToSaveFactory;
        _apiaryToolHelper = apiaryToolHelper;
        _pickerItemFactories = pickerItemFactories;
        InitializeComponent();
        LoadData();
	}

    private void LoadData()
    {
        ViewModels.BaseViewModel.PickerItemListVM<SyrupCalculationBaseType> scbt1 = 
            _pickerItemFactories.CreatePickerItemListVMFromEnum<SyrupCalculationBaseType>();
        ViewModels.BaseViewModel.PickerItemListVM<SyrupCalculationRatioType> scbt2 =
            _pickerItemFactories.CreatePickerItemListVMFromEnum<SyrupCalculationRatioType>();
        ViewModel = _viewModelsFactory.CreateApiaryToolSyrupCalculatorMainVM(scbt1, scbt2);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}