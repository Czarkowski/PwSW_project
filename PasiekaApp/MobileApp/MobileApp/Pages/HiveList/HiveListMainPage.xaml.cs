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

public partial class HiveListMainPage : ScrollablePage
{
    private HiveDetailsVM SelectedHive { get; set; }
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
        InitializeComponent();
        LoadData();
    }

    private async void LoadData()
    {
        UlListModel.ItemsSource = _viewModelsFactories.CreateUlListVMs();
    }

    private async void OnAddItemClicked(object sender, EventArgs e)
    {
        //var newItem = new Item { Name = "New Item" };
        //await App.Database.SaveItemAsync(newItem);
        _beeService.AddHive(_dataToSaveFactory.CreateNewHive());
        LoadData();
    }

    private void OnItemSelected(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as UlListVM;

        if (selectedItem != null)
        {
            SetSelect(selectedItem.Id);
        }
    }

    private void SetSelect(int hiveId)
    {
        SelectedHive = _viewModelsFactories.CreateUlDetailsVM(hiveId);
        UlDetailsModel.BindingContext = SelectedHive;
        UlDetailsModel.IsVisible = true;
    }

    private void UpdateCurrentHive()
    {
        if (SelectedHive.IsNull())
            return;
        var hive = _beeService.GetHiveById(SelectedHive.Id);
        _updateDataHelper.UpdateHiveDetails(ref hive, SelectedHive);
        _beeService.UpdateHive(hive);

        RefreshHiveList();
        SetSelect(SelectedHive.Id);
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
        SelectedHive.QueenAddDate = result.Item1;
        SelectedHive.BeeQueen = result.Item2;
        UpdateCurrentHive();
    }

    private void OnRemoveQueenClicked(object sender, EventArgs e)
    {
        SelectedHive.BeeQueen = null;
        SelectedHive.QueenAddDate = null;
        UpdateCurrentHive();
    }

    private void OnRemoveHiveClicked(object sender, EventArgs e)
    {
        _beeService.DeleteHive(SelectedHive.Id);
        SelectedHive = null;
        RefreshHiveList();

        UlDetailsModel.IsVisible = false;
        UlDetailsModel.BindingContext = null;
    }

    private void OnHiveReviewHistoryClicked(object sender, EventArgs e)
    {
        var page = PagesHelper.EditQueen;
        int? id = (e.CurrentSelection.ElementAt(0) as QueenListVM)?.Id;
        if (!id.HasValue)
            return;
        page.InitializeData(_beeService.GetQueenById(id.Value));
        page.OnSave += (s, e) => RefreshList();
        await Navigation.PushAsync(page);
    }


    private void OnEntryUnfocused(object sender, FocusEventArgs e)
    {
        UpdateCurrentHive();
    }
}