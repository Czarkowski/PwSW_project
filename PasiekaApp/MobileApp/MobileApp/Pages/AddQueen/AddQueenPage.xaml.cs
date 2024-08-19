using Data.Core.Models;
using Data.Core.Services;
using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MobileApp.Factories.Interfaces;
using MobileApp.StaticProviders;
using MobileApp.StaticResources;
using MobileApp.ViewModels;
using MobileApp.ActionSubscriber;

namespace MobileApp.Pages;

public partial class AddQueenPage : ContentPage
{
    public event EventHandler<EventArgs> OnSave;

    private QueenDetailsVM _queenDetailsVM;
    private readonly IBeeService _beeService;
    private readonly IDataToSaveFactory _dataToSaveFactories;
    public AddQueenPage(IBeeService beeService, IDataToSaveFactory dataToSaveFactories)
	{
        _beeService = beeService;
        _dataToSaveFactories = dataToSaveFactories;
        InitializeComponent();
        InitializeData();
    }

    private void InitializeData()
    {
        _queenDetailsVM = new QueenDetailsVM()
        {
            Description = "Nowa matka",
            Race = (Application.Current.Resources[StaticResourceKeys.AvailableRaces] as List<Rasa>)[0],
            BirthDate = DateTime.Now.Date,
        };
        BindingContext = _queenDetailsVM;
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        var queen = _dataToSaveFactories.CreateMatkaPszczela(_queenDetailsVM);
        _beeService.AddNewQueen(queen);
        OnSave?.Invoke(this, EventArgs.Empty);
        // Powr�t do poprzedniej strony
        await Navigation.PopAsync();
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        //_queenDetailsVM.Race = (Application.Current.Resources[StaticResources.StaticResourceKeys.AvailableRaces] as List<Rasa>)[0];
        //_queenDetailsVM.Description = "jisudfh";
        await Navigation.PopAsync();
    }
}