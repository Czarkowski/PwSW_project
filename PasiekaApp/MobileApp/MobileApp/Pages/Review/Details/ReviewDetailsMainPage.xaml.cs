using Data.Core.Services.Interfaces;
using MobileApp.Core.Classes;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.ViewModels;
using System.Windows.Input;

namespace MobileApp.Pages;

public partial class ReviewDetailsMainPage : ContentPage
{
    public NotifiObject<ReviewDetailsVM> ReviewDetailsVM;
    public ICommand _onLeft;
    public ICommand OnLeft { get => _onLeft; set { _onLeft = value; OnPropertyChanged(nameof(OnLeft)); } }
    public ICommand _onRight;
    public ICommand OnRight { get => _onRight; set { _onRight = value; OnPropertyChanged(nameof(OnRight)); } }
    private readonly IBeeService _beeService;
    private readonly IViewModelsFactory _viewModelsFactory;
    private readonly IDataToSaveFactory _dataToSaveFactory;
    private readonly IUpdateDataHelper _updateDataHelper;   
	public ReviewDetailsMainPage(IBeeService beeService, IViewModelsFactory viewModelsFactory, IDataToSaveFactory dataToSaveFactory, IUpdateDataHelper updateDataHelper)
	{
        _beeService = beeService;
        _viewModelsFactory = viewModelsFactory;
        _dataToSaveFactory = dataToSaveFactory;
        _updateDataHelper = updateDataHelper;
		InitializeComponent();
        InitializeCommand();
        LoadData();
    }

    private void LoadData()
    {
        _beeService.GetReview();
    }

    private void InitializeCommand()
    {
    }
}