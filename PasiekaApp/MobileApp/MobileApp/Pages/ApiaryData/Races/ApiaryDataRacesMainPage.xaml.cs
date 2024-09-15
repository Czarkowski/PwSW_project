using Data.Core.Models;
using Data.Core.Services;
using Data.Core.Services.Interfaces;
using MobileApp.Factories.Interfaces;
using MobileApp.Localizations;
using MobileApp.ViewModels;
using System.Windows.Input;

namespace MobileApp.Pages;

public partial class ApiaryDataRacesMainPage : ContentPage
{
    private ApiaryDataRacesMainVM _viewModel;
    public ApiaryDataRacesMainVM ViewModel
    {
        get { return _viewModel; }
        set { _viewModel = value; OnPropertyChanged(); }
    }
    public ICommand OnEdit { get; set; }
    private readonly IBeeService _beeService;
    private readonly IViewModelsFactory _viewModelsFactory;
    private readonly IDataToSaveFactory _dataToSaveFactory;
    public ApiaryDataRacesMainPage(IBeeService beeService, IViewModelsFactory viewModelsFactory, IDataToSaveFactory dataToSaveFactory)
	{
        _beeService = beeService;
        _viewModelsFactory = viewModelsFactory;
        _dataToSaveFactory = dataToSaveFactory;
		InitializeComponent();
        InitializeCommands();
        LoadData();
	}

    protected override void OnAppearing()
    {
        if (ViewModel == null)
        {
            LoadData();
        }
    }

    private void LoadData()
    {
        List<Race> races = _beeService.GetAllRaces(isVisible: false);
        ViewModel = _viewModelsFactory.CreateApiaryDataRacesMainVM(races);
    }

    private void InitializeCommands()
    {
        OnEdit = new Command(OnEditClicked);
    }

    private async void OnEditClicked(object sender)
    {
        if (sender is RaceItemVM item)
        {
            string result = string.Empty;
            bool isCorrect = false;
            do
            {
                result = await this.DisplayPromptAsync(
                    LocalizeManager.Translate("txt_ValueEdit"),
                    LocalizeManager.Translate("txt_Name"),
                    initialValue: item.Name,
                    maxLength: 100,
                    keyboard: Keyboard.Text
                    );

                if (!string.IsNullOrEmpty(result))
                {
                    isCorrect = true;
                }
                else
                {
                    return;
                }

            } while (!isCorrect);

            Race race = item.Race;
            race.Name = result;
            _beeService.UpdateRace(race);
            LoadData();
        }
    }
    private void IsVisible_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (sender is CheckBox checkBox && checkBox.BindingContext is RaceItemVM raceItem)
        {
            Race race = raceItem.Race;
            if (race.IsVisible != raceItem.IsVisible)
            {
                race.IsVisible = raceItem.IsVisible;
                _beeService.UpdateRace(race);
                LoadData();
            }
        }
    }


    private void AddRace_Clicked(object sender, EventArgs e)
    {
        Race race = _dataToSaveFactory.CreateRace(ViewModel.AddRaceMainVM);
        _beeService.AddRace(race);
        LoadData();
    }
}