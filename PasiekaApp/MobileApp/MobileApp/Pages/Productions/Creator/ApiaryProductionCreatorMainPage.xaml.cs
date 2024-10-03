using Data.Core.Models;
using Data.Core.Services;
using Data.Core.Services.Interfaces;
using MobileApp.Core.BasePages;
using MobileApp.Factories;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.Keys;
using MobileApp.Localizations;
using MobileApp.Productions;
using MobileApp.ViewModels;
using MobileApp.ViewModels.BaseViewModel;

namespace MobileApp.Pages;
public partial class ApiaryProductionCreatorMainPage : BaseContentPage<ApiaryProductionCreatorMainVM>
{
    private readonly IBeeService _beeService;
    private readonly IViewModelsFactory _viewModelsFactory;
    private readonly IDataToSaveFactory _dataToSaveFactory;
    private readonly IApiaryToolHelper _apiaryToolHelper;
    private readonly IPickerItemFactory _pickerItemFactory;
    public ApiaryProductionCreatorMainPage(IBeeService beeService, IViewModelsFactory viewModelsFactory,
        IDataToSaveFactory dataToSaveFactory, IApiaryToolHelper apiaryToolHelper, IPickerItemFactory pickerItemFactories)
	{
        _beeService = beeService;
        _viewModelsFactory = viewModelsFactory;
        _dataToSaveFactory = dataToSaveFactory;
        _apiaryToolHelper = apiaryToolHelper;
        _pickerItemFactory = pickerItemFactories;
        InitializeComponent();
        LoadData();
    }

    protected override void LoadData()
    {
        PickerItemListVM<UnitType> unitTypes = 
            _pickerItemFactory.CreatePickerItemListVMFromEnum<UnitType>();
        List<ProductionType> productionTypes = _beeService.GetAllProductionType(isVisible: true);
        PickerItemListVM<ProductionType> productionTypePickerItemListVM = 
            _pickerItemFactory.CreatePickerItemListVM<ProductionType>(productionTypes, x => x.Name);
        List<Hive> hives = _beeService.GetAllHive();
        ViewModel = _viewModelsFactory.CreateApiaryProductionCreatorMainVM(unitTypes, productionTypePickerItemListVM, hives);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    protected override async void OnAppearing()
    {
        if ((ViewModel?.ProductionTypePickerVM.ItemList.Count ?? 0) == 0)
        {
            await DisplayAlert(LocalizeManager.Translate("txt_NoApiaryData"), LocalizeManager.Translate("txt_NoProductionType"), LocalizeManager.Translate("Txt_Ok"));
            await Shell.Current.GoToAsync(RouteKeys.ApiaryDataProdutionsMainPage_Path);
        }
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        ViewModel?.HiveListVM?.OnSelectedCommand?.Execute(e);
    }
}