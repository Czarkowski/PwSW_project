using Data.Core;
using MobileApp.Localizations;
using MobileApp.ViewModels;

namespace MobileApp.Pages;

public partial class DataSettingsMainPage : ContentPage
{
	private DataSettingsMainVM _viewModel;
	public DataSettingsMainVM ViewModel
    {
		get => _viewModel;
		set
		{
            _viewModel = value;
			OnPropertyChanged();
        }
	}
    public DataSettingsMainPage()
	{
		InitializeComponent();
	}
	private async void OnClearDataBasesClicked(object sender, EventArgs e)
    {
        bool isConfirmed = await Application.Current.MainPage.DisplayAlert(
            LocalizeManager.Translate("txt_ClearDataBase"),
            LocalizeManager.Translate("txt_ClearDataBaseConfirmationText"),
            LocalizeManager.Translate("txt_Yes"),
            LocalizeManager.Translate("txt_No"));

        if (isConfirmed)
        {
            ResetDatabase();
        }
    }

    private void ResetDatabase()
    {
        BeeDbContext.ClearDataBase();
        App.Current.InitializeData();
        App.Current.InitializeMainPage();
    }
}