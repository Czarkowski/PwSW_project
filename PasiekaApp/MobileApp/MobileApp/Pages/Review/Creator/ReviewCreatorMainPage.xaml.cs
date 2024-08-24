using Data.Core.Services.Interfaces;
using MobileApp.Factories.Interfaces;
using MobileApp.ViewModels;
using System.Collections.ObjectModel;

namespace MobileApp.Pages;

public partial class ReviewCreatorMainPage : ContentPage
{
    private ObservableCollection<HiveListToCreateReviewVM> _hiveList;
	public ObservableCollection<HiveListToCreateReviewVM> HiveList { get => _hiveList; set {_hiveList = value; OnPropertyChanged(nameof(HiveList)); } }

    private readonly IBeeService _beeService;
    private readonly IViewModelsFactory _viewModelsFactory;
    public ReviewCreatorMainPage(IBeeService beeService, IViewModelsFactory viewModelsFactory)
	{
        _beeService = beeService;
        _viewModelsFactory = viewModelsFactory;
		InitializeComponent();
        LoadData();
	}

    private void LoadData()
    {
        var hives = _beeService.GetAllHive();
        List<HiveListToCreateReviewVM> hiveListToCreateReviewVMs = _viewModelsFactory.CreateHiveListToCreateReviewVM(hives);
        HiveList = new ObservableCollection<HiveListToCreateReviewVM>(hiveListToCreateReviewVMs);
    }

    public async void OnCreateReviewClicked(object sender, EventArgs e)
    {

    }
}