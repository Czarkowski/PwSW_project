using Data.Core.Services.Interfaces;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MobileApp.Factories.Interfaces;
using MobileApp.ViewModels;

namespace MobileApp.Pages;

public partial class AddRaceMainPage : ContentPage
{
	private AddRaceMainVM _addRaceMainVM;
	public AddRaceMainVM AddRaceMainVM
    {
        get => _addRaceMainVM;
        set
		{
			_addRaceMainVM = value;
			OnPropertyChanged();
		}
    }
    private readonly IBeeService _beeService;
    private readonly IViewModelsFactory _viewModelsFactory;
    private readonly IDataToSaveFactory _dataToSaveFactory;
	public AddRaceMainPage(IBeeService beeService, IViewModelsFactory viewModelsFactory, IDataToSaveFactory dataToSaveFactory)
	{
        _beeService = beeService;
        _viewModelsFactory = viewModelsFactory;
        _dataToSaveFactory = dataToSaveFactory;
		InitializeComponent();
        LoadData();
	}

    private void LoadData()
    {
        AddRaceMainVM = _viewModelsFactory.CreateAddRaceMainVM();
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        Data.Core.Models.Race race = _dataToSaveFactory.CreateRace(AddRaceMainVM);
        _beeService.AddRace(race);
        await Navigation.PopAsync();
    }
}