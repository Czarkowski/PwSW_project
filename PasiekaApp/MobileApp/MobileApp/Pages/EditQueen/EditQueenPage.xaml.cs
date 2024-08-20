using Data.Core.Models;
using Data.Core.Services;
using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MobileApp.Factories.Interfaces;
using MobileApp.StaticProviders;
using MobileApp.StaticResources;
using MobileApp.ViewModels;
using MobileApp.ActionSubscriber;
using MobileApp.Helpers.Interfaces;

namespace MobileApp.Pages;

public partial class EditQueenPage : ContentPage
{
    public event EventHandler<EventArgs> OnSave;

    private MatkaPszczela _queen;

    private List<Ul> _availableHives;
    public List<Ul> AvailableHives { get => _availableHives; set { _availableHives = value; OnPropertyChanged(nameof(AvailableHives)); } }
    private QueenDetailsVM QueenDetailsVM;

    private readonly IBeeService _beeService;
    private readonly IDataToSaveFactory _dataToSaveFactories;
    private readonly IViewModelsFactory _viewModelsFactory;
    private readonly IUpdateDataHelper _updateDataHelper;
    public EditQueenPage(IBeeService beeService, IDataToSaveFactory dataToSaveFactories, IViewModelsFactory viewModelsFactory, IUpdateDataHelper updateDataHelper)
	{
        _beeService = beeService;
        _dataToSaveFactories = dataToSaveFactories;
        _viewModelsFactory = viewModelsFactory;
        _updateDataHelper = updateDataHelper;
        BindingContext = QueenDetailsVM;
        InitializeComponent();
    }

    public void InitializeData(MatkaPszczela matkaPszczela)
    {
        _queen = matkaPszczela;
        BindingContext = QueenDetailsVM = _viewModelsFactory.CreateQueenDetailsVM(matkaPszczela);
        AvailableHives = _beeService.GetAllHiveWithoutQueens();
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        _updateDataHelper.UpdateQueenDetails(ref _queen, QueenDetailsVM);
        _beeService.UpdateQueen(_queen);
        OnSave?.Invoke(this, EventArgs.Empty);
        // Powrót do poprzedniej strony
        await Navigation.PopAsync();
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        _beeService.DeleteQueen(_queen);
        OnSave?.Invoke(this, EventArgs.Empty);
        await Navigation.PopAsync();
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}