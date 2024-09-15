using Data.Core.Models;
using Data.Core.Services.Interfaces;
using MobileApp.Factories.Interfaces;
using MobileApp.Localizations;
using MobileApp.ViewModels;
using System.Windows.Input;

namespace MobileApp.Pages;

public partial class ApiaryDataReviewsMainPage : ContentPage
{
	private ApiaryDataReviewsMainVM _viewModel;
	public ApiaryDataReviewsMainVM ViewModel
	{
		get { return _viewModel; }
		set { _viewModel = value; OnPropertyChanged(); }
	}
    public ICommand OnEdit { get; set; }

    private readonly IBeeService _beeService;
    private readonly IViewModelsFactory _viewModelsFactory;
    private readonly IDataToSaveFactory _dataToSaveFactory;

    public ApiaryDataReviewsMainPage(IBeeService beeService, IViewModelsFactory viewModelsFactory, IDataToSaveFactory dataToSaveFactory)
	{
        _beeService = beeService;
        _viewModelsFactory = viewModelsFactory;
        _dataToSaveFactory = dataToSaveFactory;
		InitializeComponent();
        InitializeCommands();
    }

    protected override void OnAppearing()
    {
        if (ViewModel == null)
        {
            LoadData();
        }
    }

    private void LoadData()
    {
        List<ReviewType> reviewType = _beeService.GetAllReviewType(isVisible: false);
        ViewModel = _viewModelsFactory.CreateApiaryDataReviewsMainVM(reviewType);
    }

    private void InitializeCommands()
    {
        OnEdit = new Command(OnEditClicked);
    }

    private async void OnEditClicked(object sender)
    {
        if (sender is ReviewTypeListItemVM item)
        {
            string result = string.Empty;
            bool isCorrect = false;
            do
            {
                result = await this.DisplayPromptAsync(
                    LocalizeManager.Translate("txt_ValueEdit"),
                    LocalizeManager.Translate("txt_Name"),
                    initialValue: item.Name,
                    maxLength: 100,
                    keyboard: Keyboard.Text
                    );

                if (!string.IsNullOrEmpty(result))
                {
                    isCorrect = true;
                }
                else
                {
                    return;
                }

            } while (!isCorrect);

            ReviewType reviewType = item.ReviewType;
            reviewType.Name = result;
            _beeService.UpdateReviewType(reviewType);
            LoadData();
        }
    }

    private void IsVisible_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is CheckBox checkBox && checkBox.BindingContext is ReviewTypeListItemVM reviewTypeListItem)
        {
            ReviewType reviewType = reviewTypeListItem.ReviewType;
            if (reviewType.IsVisible != reviewTypeListItem.IsVisible)
            {
                reviewType.IsVisible = reviewTypeListItem.IsVisible;
                _beeService.UpdateReviewType(reviewType);
                LoadData();
            }
        }
    }


    private void AddReviewType_Clicked(object sender, EventArgs e)
    {
        ReviewType reviewType = _dataToSaveFactory.CreateReviewType(ViewModel.AddReviewTypeVM);
        _beeService.AddReviewType(reviewType);
        LoadData();
    }

    private void ModifyReviewType_Clicked(object sender, EventArgs e)
    {
        if (ViewModel.ReviewTypeListVM.SelectedItem?.ReviewType is ReviewType reviewType)
        {
            reviewType.Description = ViewModel.AddReviewTypeVM.Description;
            reviewType.Name = ViewModel.AddReviewTypeVM.Name;
            _beeService.UpdateReviewType(reviewType);
            LoadData();
        }
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (ViewModel.ReviewTypeListVM.SelectedItem?.ReviewType is ReviewType reviewType)
        {
            ViewModel.AddReviewTypeVM.Name = reviewType.Name;
            ViewModel.AddReviewTypeVM.Description = reviewType.Description;
        }
    }
}