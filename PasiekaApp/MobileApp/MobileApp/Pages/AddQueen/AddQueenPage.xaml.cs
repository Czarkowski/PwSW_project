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

    private QueenDetailsVM QueenDetailsVM;
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
        QueenDetailsVM = new QueenDetailsVM()
        {
            Description = "Nowa matka",
            Race = (App.Current.Resources[StaticResourceKeys.AvailableRaces] as List<Race>)[0],
            BirthDate = DateTime.Now.Date,
        };
        BindingContext = QueenDetailsVM;
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        var queen = _dataToSaveFactories.CreateBeeGueen(QueenDetailsVM);
        _beeService.AddQueen(queen);
        OnSave?.Invoke(this, EventArgs.Empty);
        // Powrót do poprzedniej strony
        await Navigation.PopAsync();
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        //_queenDetailsVM.Race = (Application.Current.Resources[StaticResources.StaticResourceKeys.AvailableRaces] as List<Rasa>)[0];
        //_queenDetailsVM.Description = "jisudfh";
        await Navigation.PopAsync();
    }
}