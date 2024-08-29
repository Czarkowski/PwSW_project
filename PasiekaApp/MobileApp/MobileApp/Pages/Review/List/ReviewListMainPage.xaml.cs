using CommunityToolkit.Mvvm.Messaging;
using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MobileApp.CommunicationMessages;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers;
using MobileApp.Helpers.Interfaces;
using MobileApp.ReferenceMessenger;
using MobileApp.ViewModels;
using System.Windows.Input;

namespace MobileApp.Pages;

public partial class ReviewListMainPage : ContentPage
{
    private ReviewListVM _reviewListVM;
    public ReviewListVM ReviewListVM { get => _reviewListVM; set { _reviewListVM = value; OnPropertyChanged(nameof(ReviewListVM)); } }
    private readonly IBeeService _beeService;
    private readonly IViewModelsFactory _viewModelsFactory;
    private readonly IFilterDataHelper _filterDataHelper;
    public ICommand _onSearch;
    public ICommand OnSearch { get => _onSearch; set { _onSearch = value; OnPropertyChanged(nameof(OnSearch)); } }
    public ICommand _onDetails;
    public ICommand OnDetails { get => _onDetails; set { _onDetails = value; OnPropertyChanged(nameof(OnDetails)); } }
    public ReviewListMainPage(IBeeService beeService, IViewModelsFactory viewModelsFactory, IFilterDataHelper filterDataHelper)
	{
        _beeService = beeService;
        _viewModelsFactory = viewModelsFactory;
        _filterDataHelper = filterDataHelper;
		InitializeComponent();
        InitializeComponentParemeters();
        LoadData();
        InitialzieReferenceMessenger();
    }

    private void InitialzieReferenceMessenger()
    {
        MessageCenter.SetRefresReviewList(this, (x) => LoadData());
    }

    private void InitializeComponentParemeters()
    {
        OnSearch = new Command(OnSearchClicked);
        OnDetails = new Command(OnSearchClicked);
    }

    private void OnSearchClicked(object sender)
    {

        var reviews = _filterDataHelper.GetFiltratedReviews(ReviewListVM.ReviewListFilterVM);
        ReviewListVM.ReviewListItemVMs = _viewModelsFactory.CreateReviewListItemVMs(reviews);
    }

    private void OnDetailsClicked(object selectedItem)
    {

    }

    private void LoadData()
    {
        ReviewListFilterVM filterVM = _viewModelsFactory.CreateReviewListFilterVM();
        var reviews = _filterDataHelper.GetFiltratedReviews(filterVM);
        ReviewListVM = _viewModelsFactory.CreateReviewListVM(reviews, filterVM);
    }

    private async void OnReviewCreateClick(object sender, EventArgs e)
    {
        var page = PagesHelper.ReviewCreatorMain;
        await Navigation.PushAsync(page);
    }

    public void OnItemSelected(object sender, SelectionChangedEventArgs e)
    {
    }


}