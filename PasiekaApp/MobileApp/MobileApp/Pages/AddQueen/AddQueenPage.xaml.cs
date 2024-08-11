using Microsoft.EntityFrameworkCore.ChangeTracking;
using MobileApp.ViewModels;

namespace MobileApp.Pages;

public partial class AddQueenPage : ContentPage
{
	public AddQueenPage()
	{
		InitializeComponent();
        this.BindingContext = new QueenDetailsVM()
        {
            Description = "Nowa matka",
        };

    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        // Pobierz dane z formularza
        string number = NumberEntry.Text;
        string race = RaceEntry.Text;
        string description = DescriptionEntry.Text;
        DateTime? date = DatePicker.Date;

        // Logika zapisywania danych
        // TODO: Dodaj kod do zapisywania matki

        // Powrót do poprzedniej strony
        await Navigation.PopAsync();
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        // Powrót do poprzedniej strony bez zapisywania
        await Navigation.PopAsync();
    }
}