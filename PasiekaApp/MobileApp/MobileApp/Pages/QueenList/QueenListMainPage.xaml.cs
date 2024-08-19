using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MobileApp.Factories.Interfaces;
using MobileApp.StaticProviders;
using MobileApp.ViewModels;
using MobileApp.ActionSubscriber;

namespace MobileApp.Pages;

public partial class QueenListMainPage : ContentPage
{
    private readonly IViewModelsFactory _viewModelsFactories;
    private readonly IBeeService _beeService;

    public List<QueenListVM> QueenListVMs { get; set; }
	public QueenListMainPage(IViewModelsFactory viewModelsFactories, IBeeService beeService)
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
        QueenListView.QueenListVMs = QueenListVMs;

    }

    private async void OnAddQueenClicked(object sender, EventArgs e)
    {
        var page = PagesProvider.AddQueen;
        page.OnSave += (s, e) => RefreshList();
        await Navigation.PushAsync(page);
    }

    private void OnQueenSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // Logika dla zmiany wyboru
    }

    public void RefreshList()
    {
        LoadData();
    }


    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();
    //    MessagingCenter.Subscribe<AddQueenPage>(this, "RefreshList", (sender) =>
    //    {
    //        LoadData();
    //    });
    //}

    //protected override void OnDisappearing()
    //{
    //    base.OnDisappearing();
    //    MessagingCenter.Unsubscribe<AddQueenPage>(this, "RefreshList");
    //}

}