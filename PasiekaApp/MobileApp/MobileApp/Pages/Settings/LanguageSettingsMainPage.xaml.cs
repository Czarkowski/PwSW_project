using Microsoft.EntityFrameworkCore.Diagnostics;
using MobileApp.MyPreferences;
using MobileApp.ViewModels;

namespace MobileApp.Pages;

public partial class LanguageSettingsMainPage : ContentPage
{
    private LanguageSettingsMainVM _viewModel;
    public LanguageSettingsMainVM ViewModel
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
        LoadData();
	}

    private void LoadData()
    {
        ViewModel = new LanguageSettingsMainVM()
        {
            LanguageListVM = new LanguageListVM()
            {
                ItemList = new List<LanguageListItemVM>()
                {
                    new LanguageListItemVM() { LanguageName = "Polski", LanguageCode = "pl" },
                    new LanguageListItemVM() { LanguageName = "English", LanguageCode = "en" }
                }

            }
        };
        if (ViewModel.LanguageListVM.ItemList.Find(x => x.LanguageCode.Equals(AppPreferences.Language)) is LanguageListItemVM languageListItemVM)
        {
            ViewModel.LanguageListVM.SelectedItem = languageListItemVM;
        }
    }

    private async void OnSaveLanguageClicked(object sender, EventArgs e)
    {
        AppPreferences.Language = ViewModel.LanguageListVM.SelectedItem.LanguageCode;
        App.Current.InitializeMainPage();
    }
}