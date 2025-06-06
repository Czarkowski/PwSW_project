using Data.Core.Models;
using Data.Core.Services;
using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MobileApp.Factories.Interfaces;
using MobileApp.ViewModels;
using MobileApp.ActionSubscriber;
using MobileApp.Helpers.StaticResources;
using MobileApp.Keys;
using MobileApp.Localizations;

namespace MobileApp.Pages;

public partial class AddQueenPage : ContentPage
{
    public event EventHandler<EventArgs> OnSave;

    private AddQueenVM _addQueenvM;
    public AddQueenVM AddQueenVM
    {
        get => _addQueenvM;
        set
        {
            _addQueenvM = value;
            OnPropertyChanged();
        }
    }
    private readonly IBeeService _beeService;
    private readonly IDataToSaveFactory _dataToSaveFactories;
    private readonly IViewModelsFactory _viewModelsFactory;
    public AddQueenPage(IBeeService beeService, IDataToSaveFactory dataToSaveFactories, IViewModelsFactory viewModelsFactory)
    {
        _beeService = beeService;
        _dataToSaveFactories = dataToSaveFactories;
        _viewModelsFactory = viewModelsFactory;
        InitializeComponent();
        InitializeData();
    }

    private void InitializeData()
    {
        List<Race> races = _beeService.GetAllRaces();
        AddQueenVM = _viewModelsFactory.CreateAddQueenVM(races);
    }

    protected override async void OnAppearing()
    {
        if ((AddQueenVM?.Races.Count ?? 0) == 0)
        {
            await DisplayAlert(LocalizeManager.Translate("txt_NoApiaryData"), LocalizeManager.Translate("txt_NoRaces"), LocalizeManager.Translate("txt_OK"));
            await Navigation.PopAsync();
            await Shell.Current.GoToAsync(RouteKeys.ApiaryDataProdutionsMainPage_Path);
        }
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        var queen = _dataToSaveFactories.CreateBeeGueen(AddQueenVM.QueenDetailsVM);
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