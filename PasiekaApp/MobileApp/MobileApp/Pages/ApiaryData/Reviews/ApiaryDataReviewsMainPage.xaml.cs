using MobileApp.ViewModels;

namespace MobileApp.Pages;

public partial class ApiaryDataReviewsMainPage : ContentPage
{
	private ApiaryDataReviewsMainVM _viewModel;
	public ApiaryDataReviewsMainVM ViewModel
	{
		get { return _viewModel; }
		set { _viewModel = value; OnPropertyChanged(); }
	}
    public ApiaryDataReviewsMainPage()
	{
		InitializeComponent();
	}
}