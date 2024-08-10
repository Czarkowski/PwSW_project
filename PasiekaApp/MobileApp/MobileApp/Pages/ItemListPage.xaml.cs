using Data.Core.Services.Interfaces;
using MobileApp.Factories.Interfaces;

namespace MobileApp.Pages;

public partial class ItemListPage : ContentPage
{
    private readonly IBeeService _beeService;
    private readonly IViewModelsFactories _viewModelsFactories;
    public ItemListPage(/*IViewModelsFactories viewModelsFactories*/ /*IServiceProvider serviceProvider*/)
    {
        InitializeComponent();
        //_viewModelsFactories = viewModelsFactories;

        LoadItems();
    }

    private async void LoadItems()
    {
        itemsCollectionView.ItemsSource = _viewModelsFactories.CreateUlListVMs();
    }

    private async void OnAddItemClicked(object sender, EventArgs e)
    {
        //var newItem = new Item { Name = "New Item" };
        //await App.Database.SaveItemAsync(newItem);
        LoadItems();
    }
}