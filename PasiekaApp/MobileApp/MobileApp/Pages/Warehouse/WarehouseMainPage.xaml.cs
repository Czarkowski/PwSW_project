using Data.Core.Services;
using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MobileApp.Factories.Interfaces;
using MobileApp.ViewModels;
using System.Windows.Input;
using System.Timers;
using MobileApp.Localizations;
using MobileApp.Resources.Languages;
using MobileApp.Helpers.Interfaces;

namespace MobileApp.Pages;

public partial class WarehouseMainPage : ContentPage
{
    private readonly System.Timers.Timer _debounceTimer = new System.Timers.Timer() 
    {
        AutoReset = false,
        Interval = 500
    };
    private readonly IBeeService _beeService;
    private readonly IViewModelsFactory _viewModelsFactory;
    private readonly IDataToSaveFactory _dataToSaveFactory;
    private readonly IUpdateDataHelper _updateDataHelper;
    private WarehouseVM _warehouseVM;
    public WarehouseVM WarehouseVM { get => _warehouseVM; set { _warehouseVM = value; OnPropertyChanged(nameof(WarehouseVM)); } }
    public ICommand OnEdit { get; set; }
    public ICommand OnDelete { get; set; }


    public WarehouseMainPage(IBeeService beeService, IViewModelsFactory viewModelsFactory, IDataToSaveFactory dataToSaveFactory, IUpdateDataHelper updateDataHelper)
	{
        _beeService = beeService;
        _viewModelsFactory = viewModelsFactory;
        _dataToSaveFactory = dataToSaveFactory;
        _updateDataHelper = updateDataHelper;
        InitializeCommands();
		InitializeComponent();
        InitializeProperties();
        LoadData();
	}

    private void InitializeProperties()
    {
        _debounceTimer.Elapsed += OnDebounceTimerElapsed;
        SearchPhraseLE.GetEntry.TextChanged += OnSearchTextChanged;
    }

    private void LoadData()
    {
        var stocks = _beeService.GetAllStock();
        WarehouseVM = _viewModelsFactory.CreateWarehouseVM(stocks);
    }

    private void InitializeCommands()
    {
        OnEdit = new Command(OnEditClicked);
        OnDelete = new Command(OnDeleteClicked);
    }

    private async void OnEditClicked(object sender)
    {
        if (sender is WarehouseListItemVM item)
        {
            double newQuantity;
            bool isCorrect = false;
            do
            {
                string result = await this.DisplayPromptAsync(
                    LocalizeManager.Translate("txt_ValueEdit"),
                    LocalizeManager.Translate("txt_DoubleValue"),
                    initialValue: item.Quantity.ToString(),
                    maxLength: 100,
                    keyboard: Keyboard.Numeric
                    );

                if (!string.IsNullOrEmpty(result))
                {
                    if (double.TryParse(result, out newQuantity))
                    {
                        isCorrect = true;
                    }
                    else
                    {
                        await this.DisplayAlert(
                            LocalizeManager.Translate("txt_InvalidValue"),
                            LocalizeManager.Translate("txt_PleaseEnterValidNumber"),
                            LocalizeManager.Translate("txt_OK")
                        );
                    }
                }
                else
                {
                    return;
                }

            } while (!isCorrect);

            Data.Core.Models.StockAvailability stockAvailability = item.StockAvailability;
            stockAvailability.Quantity = newQuantity;
            _beeService.UpdateStock(stockAvailability);
            LoadData(); 
        }
    }

    private void OnDeleteClicked(object sender)
    {
		if (sender is WarehouseListItemVM item)
		{
            _beeService.DeleteStock(item.StockAvailability);
            LoadData();
		}
    }

    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        _debounceTimer.Stop();
        _debounceTimer.Start();
    }

    private void OnDebounceTimerElapsed(object sender, ElapsedEventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            FilterList();
        });
    }

    private void FilterList()
    {
        WarehouseVM.ApplyFilter();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var newItem = _dataToSaveFactory.CreateStockAvailability(WarehouseVM.NewWarehouseItemVM);
        _beeService.AddStock(newItem);
        LoadData();
    }
}