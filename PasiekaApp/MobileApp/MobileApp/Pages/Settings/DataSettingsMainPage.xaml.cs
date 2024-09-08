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
}