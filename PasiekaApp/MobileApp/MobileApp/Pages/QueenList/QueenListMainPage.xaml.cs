using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MobileApp.Factories.Interfaces;
using MobileApp.ViewModels;

namespace MobileApp.Pages;

public partial class QueenListMainPage : ContentPage
{
    private readonly IViewModelsFactories _viewModelsFactories;
    private readonly IBeeService _beeService;

    public List<QueenListVM> QueenListVMs { get; set; }
	public QueenListMainPage(IViewModelsFactories viewModelsFactories, IBeeService beeService)
	{
        _viewModelsFactories = viewModelsFactories;
        _beeService = beeService;

		InitializeComponent();

        LoadData();
	}

    private void LoadData()
    {
        List<Data.Core.Models.MatkaPszczela> matkaPszczelas = _beeService.GetAllQueens();
        QueenListVMs = _viewModelsFactories.CreateQueenListVM(matkaPszczelas);
        queenListView.QueenListVMs = QueenListVMs;

    }

    private async void OnAddQueenClicked(object sender, EventArgs e)
    {
        // Logika dla dodawania nowej matki
        await Navigation.PushAsync(new AddQueenPage());
    }

    private void OnQueenSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // Logika dla zmiany wyboru
    }

}