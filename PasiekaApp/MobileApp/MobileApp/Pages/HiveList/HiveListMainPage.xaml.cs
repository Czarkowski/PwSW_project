using CommunityToolkit.Maui.Views;
using Data.Core.Models;
using Data.Core.Services.Interfaces;
using MobileApp.Core.BasePages;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.StaticProviders;
using MobileApp.ViewModels;
using Utilities.StaticExtensions;

namespace MobileApp.Pages;

public partial class HiveListMainPage : ScrollablePage
{
    private HiveDetailsVM SelectedHive { get; set; }
    private readonly IBeeService _beeService;
    private readonly IViewModelsFactory _viewModelsFactories;
    private readonly IUpdateDataHelper _updateDataHelper;
    public HiveListMainPage(IViewModelsFactory viewModelsFactories, IUpdateDataHelper updateDataHelper)
    {
        _viewModelsFactories = viewModelsFactories;
        _updateDataHelper = updateDataHelper;
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
        LoadData();
    }

    private void OnItemSelected(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as UlListVM;

        if (selectedItem != null)
        {
            SelectedHive = _viewModelsFactories.CreateUlDetailsVM(selectedItem.Id);
            UlDetailsModel.BindingContext = SelectedHive;
            UlDetailsModel.IsVisible = true;
        }
    }

    private void OnSaveChangesClicked(object sender, EventArgs e)
    {
        //SelectedHive = (UlDetailsModel.BindingContext as HiveDetailsVM);
        if (SelectedHive.IsNull())
            return;

        var hive = _beeService.GetHiveById(SelectedHive.Id);
        _updateDataHelper.UpdateHiveDetails(ref hive, SelectedHive);
        _beeService.UpdateHive(hive);
    }

    private async void OnChangeQueenClicked(object sender, EventArgs e)
    {
        var popup = PagesProvider.ChangeQueenPopup;
        var result = await this.ShowPopupAsync(popup) as Tuple<DateTime, BeeQueen>;
        if (result.IsNull())
            return;
        SelectedHive.QueenAddDate = result.Item1;
        SelectedHive.BeeQueen = result.Item2;
    }
}