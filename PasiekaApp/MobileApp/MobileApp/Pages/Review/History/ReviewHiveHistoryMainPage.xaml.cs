using Data.Core.Models;
using Data.Core.Services.Interfaces;
using MobileApp.Factories;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers;
using MobileApp.Helpers.Interfaces;
using MobileApp.ViewModels;
using System.Windows.Input;

namespace MobileApp.Pages;

public partial class ReviewHiveHistoryMainPage : ContentPage
{
    private Hive _hive;
    private ReviewHiveHistoryVM _reviewHistoryVM;
    public ReviewHiveHistoryVM ReviewHistoryVM
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
    private readonly IFilterPredicateHelper _filterPredicateHelper;
	public ReviewHiveHistoryMainPage(IViewModelsFactory viewModelsFactory, IBeeService beeService, 
        IFilterDataHelper filterDataHelper, IFilterPredicateHelper filterPredicateHelper)
	{
		_viewModelsFactory = viewModelsFactory;
		_beeService = beeService;
        _filterDataHelper = filterDataHelper;
        _filterPredicateHelper = filterPredicateHelper;
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
        FilterList();
    }

    private void FilterList()
    {
        var predicate = _filterPredicateHelper.PrepearFilterForReviewHistoryListItemVM(ReviewHistoryVM.ReviewHistoryListFilterVM);
        ReviewHistoryVM.ReviewHistoryListVM.ApplyFilter(predicate);
    }

    private void OnDetailsClicked(ReviewHistoryListItemVM selectedItem)
    {

    }

    public void InitializeData(Hive hive)
    {
        _hive = hive;
        LoadData();
    }

    public void LoadData()
    {
        ReviewHistoryVM = _viewModelsFactory.CreateReviewHistoryVM(_hive);
        FilterList();
    }

    private void OnItemSelected(object sender, SelectionChangedEventArgs e)
    {
        ReviewHistoryVM.DescriptionHiveReviewVM = _viewModelsFactory.CreateDescriptionHiveReviewVM(
            ReviewHistoryVM.ReviewHistoryListVM.SelectedItem.DescriptionHiveReview);
    }
}