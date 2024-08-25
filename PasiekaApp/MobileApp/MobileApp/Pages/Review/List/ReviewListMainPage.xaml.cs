using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.ViewModels;

namespace MobileApp.Pages;

public partial class ReviewListMainPage : ContentPage
{
	public ReviewListVM ReviewListVM { get; set; }
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
}