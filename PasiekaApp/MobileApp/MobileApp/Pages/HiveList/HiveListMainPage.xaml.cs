using CommunityToolkit.Maui.Views;
using Data.Core.Models;
using Data.Core.Services;
using Data.Core.Services.Interfaces;
using MobileApp.Core.BasePages;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers;
using MobileApp.Helpers.Interfaces;
using MobileApp.ViewModels;
using Utilities.StaticExtensions;

namespace MobileApp.Pages;

public partial class HiveListMainPage : ContentPage
{
    public bool RefreshRequiered { get; set; } = true;
    private HiveListMainVM _hiveListMainVM;
    public HiveListMainVM HiveListMainVM
    {
        get => _hiveListMainVM;
        set
        {
            _hiveListMainVM = value;
            OnPropertyChanged();
        }
    }
    private readonly IBeeService _beeService;
    private readonly IViewModelsFactory _viewModelsFactories;
    private readonly IUpdateDataHelper _updateDataHelper;
    private readonly IDataToSaveFactory _dataToSaveFactory;
    public HiveListMainPage(IViewModelsFactory viewModelsFactories, IUpdateDataHelper updateDataHelper, IBeeService beeService, IDataToSaveFactory dataToSaveFactory)
    {
        _dataToSaveFactory = dataToSaveFactory;
        _viewModelsFactories = viewModelsFactories;
        _updateDataHelper = updateDataHelper;
        _beeService = beeService;
        //LoadData();
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        if (RefreshRequiered)
        {
            LoadData();
            //RefreshRequiered = false;
        }
    }

    private async void LoadData()
    {
        List<Hive> hives = _beeService.GetAllHive();
        HiveListMainVM = _viewModelsFactories.CreateHiveListMainVM(hives);
    }

    private async void OnAddItemClicked(object sender, EventArgs e)
    {
        //var newItem = new Item { Name = "New Item" };
        //await App.Database.SaveItemAsync(newItem);
        _beeService.AddHive(_dataToSaveFactory.CreateEmptyHive());
        LoadData();
    }

    private void OnItemSelected(object sender, SelectionChangedEventArgs e)
    {
        SetSelectDetails(HiveListMainVM.HiveListVM.SelectedItem?.Hive);
    }

    private void SetSelectDetails(Hive hive)
    {
        if (hive == null)
        {
            HiveListMainVM.HiveDetailsVM = null;
            return;
        }
        var hiveVM = _viewModelsFactories.CreateHiveDetailsVM(hive);
        HiveListMainVM.HiveDetailsVM = hiveVM;
    }

    private void UpdateCurrentHive()
    {
        if (HiveListMainVM.HiveDetailsVM.IsNull())
            return;
        var hive = HiveListMainVM.HiveDetailsVM.Hive;
        _updateDataHelper.UpdateHiveDetails(ref hive, HiveListMainVM.HiveDetailsVM);
        _beeService.UpdateHive(hive);

        RefreshHiveList();
        SetSelectDetails(hive);
    }

    private void RefreshHiveList()
    {
        LoadData();
    }

    private async void OnAddQueenClicked(object sender, EventArgs e)
    {
        var popup = PagesHelper.ChangeQueenPopup;
        var result = await this.ShowPopupAsync(popup) as Tuple<DateTime, BeeQueen>;
        if (result.IsNull())
            return;
        HiveListMainVM.HiveDetailsVM.QueenAddDate = result.Item1;
        HiveListMainVM.HiveDetailsVM.BeeQueen = result.Item2;
        UpdateCurrentHive();
    }

    private void OnRemoveQueenClicked(object sender, EventArgs e)
    {
        HiveListMainVM.HiveDetailsVM.BeeQueen = null;
        HiveListMainVM.HiveDetailsVM.QueenAddDate = null;
        UpdateCurrentHive();
    }

    private void OnRemoveHiveClicked(object sender, EventArgs e)
    {
        _beeService.DeleteHive(HiveListMainVM.HiveDetailsVM.Hive);
        HiveListMainVM.HiveDetailsVM = null;
        RefreshHiveList();

        UlDetailsModel.IsVisible = false;
        UlDetailsModel.BindingContext = null;
    }

    private async void OnHiveReviewHistoryClicked(object sender, EventArgs e)
    {
        var page = PagesHelper.ReviewHistoryMain;
        page.InitializeData(HiveListMainVM.HiveDetailsVM.Hive);
        await Navigation.PushAsync(page);
    }


    private void OnEntryUnfocused(object sender, FocusEventArgs e)
    {
        UpdateCurrentHive();
    }
}