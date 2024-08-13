using Data.Core.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MobileApp.ViewModels;

namespace MobileApp.Pages;

public partial class AddQueenPage : ContentPage
{
    private QueenDetailsVM _queenDetailsVM;
    public AddQueenPage()
	{

        InitializeComponent();
        InitializeData();
    }

    private void InitializeData()
    {
        _queenDetailsVM = new QueenDetailsVM()
        {
            Description = "Nowa matka",
            Race = (Application.Current.Resources[StaticResources.StaticResourceKeys.AvailableRaces] as List<Rasa>)[0],
            RaceId = 1,
        };
        BindingContext = _queenDetailsVM;
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        

        // Logika zapisywania danych
        // TODO: Dodaj kod do zapisywania matki

        // Powrót do poprzedniej strony
        await Navigation.PopAsync();
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        _queenDetailsVM.Race = (Application.Current.Resources[StaticResources.StaticResourceKeys.AvailableRaces] as List<Rasa>)[0];
        _queenDetailsVM.Description = "jisudfh";
        //await Navigation.PopAsync();
    }
}