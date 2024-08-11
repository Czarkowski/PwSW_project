using Data.Core.Services.Interfaces;
using MobileApp.Factories;
using MobileApp.Factories.Interfaces;
using MobileApp.ViewModels;

namespace MobileApp.Pages;

public partial class HiveListMainPage : ContentPage
{
    private readonly IBeeService _beeService;
    private readonly IViewModelsFactories _viewModelsFactories;
    public HiveListMainPage(IViewModelsFactories viewModelsFactories)
    {
        InitializeComponent();
        _viewModelsFactories = viewModelsFactories;

        LoadItems();
    }

    private async void LoadItems()
    {
        ulListModel.ItemsSource = _viewModelsFactories.CreateUlListVMs();
    }

    private async void OnAddItemClicked(object sender, EventArgs e)
    {
        //var newItem = new Item { Name = "New Item" };
        //await App.Database.SaveItemAsync(newItem);
        LoadItems();
    }

    private void OnItemSelected(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as UlListVM;

        if (selectedItem != null)
        {
            UlDetailsVM ulDetailsVMM = _viewModelsFactories.CreateUlDetailsVM(selectedItem.Id);
            ulDetailsModel.BindingContext = ulDetailsVMM;
            ulDetailsModel.IsVisible = true;
        }
    }

    private void OnSaveChangesClicked(object sender, EventArgs e)
    {

    }
}