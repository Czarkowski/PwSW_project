using Data.Core.Services.Interfaces;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.Keys;
using MobileApp.Localizations;
using MobileApp.ReferenceMessenger;
using MobileApp.ViewModels;
using System.Collections.ObjectModel;

namespace MobileApp.Pages;

public partial class ReviewCreatorMainPage : ContentPage
{
 //   private ObservableCollection<HiveListToCreateReviewVM> _hiveList;
	//public ObservableCollection<HiveListToCreateReviewVM> HiveList { get => _hiveList; set {_hiveList = value; OnPropertyChanged(nameof(HiveList)); } }

    public ReviewCreatorVM ReviewCreatorVM { get; set; }

    private readonly IBeeService _beeService;
    private readonly IViewModelsFactory _viewModelsFactory;
    private readonly IDataToSaveFactory _dataToSaveFactory;
    private readonly INotificationHelper _notificationHelper;
    public ReviewCreatorMainPage(IBeeService beeService, IViewModelsFactory viewModelsFactory, IDataToSaveFactory dataToSaveFactory,
        INotificationHelper notificationHelper)
	{
        _beeService = beeService;
        _viewModelsFactory = viewModelsFactory;
        _dataToSaveFactory = dataToSaveFactory;
        _notificationHelper = notificationHelper;
		InitializeComponent();
        LoadData();
	}

    private void LoadData()
    {
        var hives = _beeService.GetAllHive();
        List<HiveListToCreateReviewVM> hiveListToCreateReviewVMs = _viewModelsFactory.CreateHiveListToCreateReviewVM(hives);
        var reviewType = _beeService.GetAllReviewType();
        ReviewCreatorVM = _viewModelsFactory.CreateReviewCreatorVM(hiveListToCreateReviewVMs, reviewType);
        //HiveList = new ObservableCollection<HiveListToCreateReviewVM>(hiveListToCreateReviewVMs);
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (ReviewCreatorVM?.ReviewTypeList.Count == 0)
        {
            await DisplayAlert(LocalizeManager.Translate("txt_NoApiaryData"), LocalizeManager.Translate("txt_NoReviewType"), LocalizeManager.Translate("Txt_Ok"));
            await Navigation.PopAsync();
            await Shell.Current.GoToAsync(RouteKeys.ApiaryDataReviewsMainPage_Path);
        }
    }

    public async void OnCreateReviewClicked(object sender, EventArgs e)
    {
        Data.Core.Models.Review review = _dataToSaveFactory.CreateReview(ReviewCreatorVM);
        _beeService.AddReview(review);
        _notificationHelper.CreateAndSetBaseNotificationForReview(review);
        MessageCenter.RefresReviewList();
        await Navigation.PopAsync();
    }
}