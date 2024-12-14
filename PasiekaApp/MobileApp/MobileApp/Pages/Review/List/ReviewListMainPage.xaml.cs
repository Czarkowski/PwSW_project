using CommunityToolkit.Mvvm.Messaging;
using Data.Core.Services.Interfaces;
using Data.Core.Models;
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
    public ICommand _onSearch;
    public ICommand OnSearch { get => _onSearch; set { _onSearch = value; OnPropertyChanged(nameof(OnSearch)); } }
    public ICommand _onDetails;
    public ICommand OnDetails { get => _onDetails; set { _onDetails = value; OnPropertyChanged(nameof(OnDetails)); } }
    private readonly IBeeService _beeService;
    private readonly IViewModelsFactory _viewModelsFactory;
    private readonly IFilterDataHelper _filterDataHelper;
    public ReviewListMainPage(IBeeService beeService, IViewModelsFactory viewModelsFactory, IFilterDataHelper filterDataHelper)
	{
        _beeService = beeService;
        _viewModelsFactory = viewModelsFactory;
        _filterDataHelper = filterDataHelper;
		InitializeComponent();
        InitializeCommand();
        InitialzieReferenceMessenger();
        LoadData();
    }

    private void InitialzieReferenceMessenger()
    {
        MessageCenter.SetRefresReviewList(this, (x) => LoadData());
    }

    private void InitializeCommand()
    {
        OnSearch = new Command(OnSearchClicked);
        OnDetails = new Command<ReviewListItemVM>(OnDetailsClicked);
    }

    private void OnSearchClicked(object sender)
    {
        var reviews = _filterDataHelper.GetFiltratedReviews(ReviewListVM.ReviewListFilterVM);
        ReviewListVM.ReviewListItemVMs = _viewModelsFactory.CreateReviewListItemVMs(reviews);
    }

    private async void OnDetailsClicked(ReviewListItemVM selectedItem)
    {
        if (selectedItem?.Review == null)
        {
            return;
        }
        var page = PagesHelper.ReviewDetailsMain;
        page.InitializeData(selectedItem.Review);
        await Navigation.PushAsync(page);
    }

    private void LoadData()
    {
        ReviewListFilterVM filterVM = _viewModelsFactory.CreateReviewListFilterVM();
        var reviews = _filterDataHelper.GetFiltratedReviews(filterVM);
        ReviewListVM = _viewModelsFactory.CreateReviewListVM(reviews, filterVM);
        ReviewListVM.ReviewListFilterVM.ReviewType = ReviewListVM.ReviewListFilterVM.ReviewTypes.Last();
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