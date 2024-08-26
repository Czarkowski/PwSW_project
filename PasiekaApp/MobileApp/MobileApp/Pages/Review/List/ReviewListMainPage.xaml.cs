using CommunityToolkit.Mvvm.Messaging;
using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MobileApp.CommunicationMessages;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers;
using MobileApp.Helpers.Interfaces;
using MobileApp.ReferenceMessenger;
using MobileApp.ViewModels;

namespace MobileApp.Pages;

public partial class ReviewListMainPage : ContentPage
{
    private ReviewListVM _reviewListVM;
    public ReviewListVM ReviewListVM { get => _reviewListVM; set { _reviewListVM = value; OnPropertyChanged(nameof(ReviewListVM)); } }
    private readonly IBeeService _beeService;
    private readonly IViewModelsFactory _viewModelsFactory;
    private readonly IFilterDataHelper _filterDataHelper;
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

        //ReviewListCV.ItemTemplate = new DataTemplate(() =>
        //{
        //    //var view = new ReviewItemView();
        //    //view.SetBinding(ReviewItemView.RealizedDateLabelProperty, new Binding("RealizedDate", StringFormat = "{0:dd-MM-yyyy}", TargetNullValue = "Brak danych"));

        //    // Apply additional modifications if necessary
        //    //view.UpdateRealizedDateLabel("Additional Text");

        //    //return new ViewCell { View = view };
        //});
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
}