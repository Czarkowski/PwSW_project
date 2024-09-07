using Data.Core.Models;
using Data.Core.Services.Interfaces;
using MobileApp.Factories;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers;
using MobileApp.Helpers.Interfaces;
using MobileApp.ViewModels;
using System.Windows.Input;

namespace MobileApp.Pages;

public partial class ReviewHistoryMainPage : ContentPage
{
    private Hive _hive;
    private ReviewHistoryVM _reviewHistoryVM;
    public ReviewHistoryVM ReviewHistoryVM
    {
        get => _reviewHistoryVM;
        set
        {
            _reviewHistoryVM = value;
            OnPropertyChanged();
        }
    }
    public ICommand _onSearch;
    public ICommand OnSearch { get => _onSearch; set { _onSearch = value; OnPropertyChanged(nameof(OnSearch)); } }
    public ICommand _onDetails;
    public ICommand OnDetails { get => _onDetails; set { _onDetails = value; OnPropertyChanged(nameof(OnDetails)); } }
    private readonly IViewModelsFactory _viewModelsFactory;
	private readonly IBeeService _beeService;
    private readonly IFilterDataHelper _filterDataHelper;
	public ReviewHistoryMainPage(IViewModelsFactory viewModelsFactory, IBeeService beeService, IFilterDataHelper filterDataHelper)
	{
		_viewModelsFactory = viewModelsFactory;
		_beeService = beeService;
        _filterDataHelper = filterDataHelper;
		InitializeComponent();
        InitializeCommand();
	}

    private void InitializeCommand()
    {
        OnSearch = new Command(OnSearchClicked);
        OnDetails = new Command<ReviewHistoryListItemVM>(OnDetailsClicked);
    }

    private void OnSearchClicked(object sender)
    {
        var reviewsHistory = _filterDataHelper.GetFiltratedDescriptionReviewsHistory(_hive, ReviewHistoryVM.ReviewHistoryListFilterVM);
        ReviewHistoryVM.ReviewHistoryListVM = _viewModelsFactory.CreateReviewHistoryListVM(reviewsHistory);
    }

    private async void OnDetailsClicked(ReviewHistoryListItemVM selectedItem)
    {
        //var page = PagesHelper.ReviewDetailsMain;
        //page.InitializeData(selectedItem.Review);
        //await Navigation.PushAsync(page);
    }

    public void InitializeData(Hive hive)
    {
        _hive = hive;
        LoadData();
    }

    public void LoadData()
    {
        ReviewHistoryVM = _viewModelsFactory.CreateReviewHistoryVM(_hive);
    }


}