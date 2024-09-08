using MobileApp.ViewModels;

namespace MobileApp.Pages;

public partial class LanguageSettingsMainPage : ContentPage
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
    public LanguageSettingsMainPage()
	{
		InitializeComponent();
	}
    private async void OnSaveLanguageClicked(object sender, EventArgs e)
    {
        string selectedLanguage = LanguagePicker.SelectedItem.ToString();

        // Ustal kod jêzyka na podstawie wyboru u¿ytkownika
        string languageCode = selectedLanguage == "Polski" ? "pl" : "en";

        Preferences.Set("AppLanguage", languageCode);

        App.Current.InitializeMainPage();
    }
}