using Data.Core.Models;
using Data.Core.Services.Interfaces;
using MobileApp.Core.BasePages;
using MobileApp.Factories.Interfaces;
using MobileApp.Localizations;
using MobileApp.ViewModels;
using System.Windows.Input;

namespace MobileApp.Pages;

public partial class ApiaryDataProdutionsMainPage : BaseContentPage<ApiaryDataProductionsMainVM>
{
    public ICommand OnEdit { get; set; }
    private readonly IBeeService _beeService;
    private readonly IViewModelsFactory _viewModelsFactory;
    private readonly IDataToSaveFactory _dataToSaveFactory;
    public ApiaryDataProdutionsMainPage(IBeeService beeService, IViewModelsFactory viewModelsFactory, IDataToSaveFactory dataToSaveFactory)
    {
        _beeService = beeService;
        _viewModelsFactory = viewModelsFactory;
        _dataToSaveFactory = dataToSaveFactory;
        InitializeComponent();
        LoadData();
        InitializeCommands();
    }

    protected override void LoadData()
    {
        List<ProductionType> ProductionType = _beeService.GetAllProductionType(isVisible: false);
        ViewModel = _viewModelsFactory.CreateApiaryDataProductionsMainVM(ProductionType);
    }

    private void InitializeCommands()
    {
        OnEdit = new Command(OnEditClicked);
    }

    private async void OnEditClicked(object sender)
    {
        if (sender is ProductionTypeListItemVM item)
        {
            string result = string.Empty;
            bool isCorrect = false;
            do
            {
                result = await this.DisplayPromptAsync(
                    LocalizeManager.Translate("txt_ValueEdit"),
                    LocalizeManager.Translate("txt_Name"),
                    initialValue: item.Name,
                    maxLength: 100,
                    keyboard: Keyboard.Text
                    );

                if (!string.IsNullOrEmpty(result))
                {
                    isCorrect = true;
                }
                else
                {
                    return;
                }

            } while (!isCorrect);

            ProductionType productionType = item.ProductionType;
            productionType.Name = result;
            _beeService.UpdateProductionType(productionType);
            LoadData();
        }
    }

    private void IsVisible_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is CheckBox checkBox && checkBox.BindingContext is ProductionTypeListItemVM productionTypeItem)
        {
            ProductionType pproductionType = productionTypeItem.ProductionType;
            if (pproductionType.IsVisible != productionTypeItem.IsVisible)
            {
                pproductionType.IsVisible = productionTypeItem.IsVisible;
                _beeService.UpdateProductionType(pproductionType);
                LoadData();
            }
        }
    }


    private void AddProductionType_Clicked(object sender, EventArgs e)
    {
        ProductionType productionType = _dataToSaveFactory.CreateProductionType(ViewModel.ProductionTypeDetailsVM);
        _beeService.AddProductionType(productionType);
        LoadData();
    }

    private void ModifyProductionType_Clicked(object sender, EventArgs e)
    {
        if (ViewModel.ProductionTypeDetailsVM?.ProductionType is ProductionType productionType)
        {
            productionType.Description = ViewModel.ProductionTypeDetailsVM.Description;
            productionType.Name = ViewModel.ProductionTypeDetailsVM.Name;
            _beeService.UpdateProductionType(productionType);
            LoadData();
        }
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (ViewModel.ProductionTypeListVM.SelectedItem?.ProductionType is ProductionType production)
        {
            ViewModel.ProductionTypeDetailsVM = _viewModelsFactory.CreateProductionTypeDetailsVM(production);
        }
    }
}