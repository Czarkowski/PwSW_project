using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MobileApp.Factories.Interfaces;
using MobileApp.ViewModels;
using MobileApp.ActionSubscriber;
using MobileApp.Helpers;

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
        List<Data.Core.Models.BeeQueen> matkaPszczelas = _beeService.GetAllQueens();
        QueenListVMs = _viewModelsFactories.CreateQueenListVM(matkaPszczelas);
        QueenListView.QueenListVMs = QueenListVMs;

    }

    private async void OnAddQueenClicked(object sender, EventArgs e)
    {
        var page = PagesHelper.AddQueen;
        page.OnSave += (s, e) => RefreshList();
        await Navigation.PushAsync(page);
    }

    private async void OnQueenSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var page = PagesHelper.EditQueen;
        int? id = (e.CurrentSelection.ElementAt(0) as QueenListVM)?.Id;
        if (!id.HasValue)
            return;
        page.InitializeData(_beeService.GetQueenById(id.Value));
        page.OnSave += (s, e) => RefreshList();
        await Navigation.PushAsync(page);
    }

    public void RefreshList()
    {
        LoadData();
    }

    private async void OnAddRaceClicked(object sender, EventArgs e)
    {
        var pare = PagesHelper.AddRaceMain;
        await Navigation.PushAsync(pare);
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