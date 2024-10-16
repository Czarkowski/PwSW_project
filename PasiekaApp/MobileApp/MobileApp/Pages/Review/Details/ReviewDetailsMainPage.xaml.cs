using Data.Core.Services.Interfaces;
using Data.Core.Models;
using MobileApp.Core.Classes;
using MobileApp.Factories.Interfaces;
using MobileApp.Helpers.Interfaces;
using MobileApp.ViewModels;
using System.Windows.Input;
using Utilities.StaticExtensions;
using MobileApp.Localizations;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using MobileApp.ReferenceMessenger;
using Data.Core.Repositories.Interfaces;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace MobileApp.Pages;

public partial class ReviewDetailsMainPage : ContentPage
{
    private Data.Core.Models.Review _review;
    private ReviewDetailsVM _reviewDetailsVM;
    public ReviewDetailsVM ReviewDetailsVM { get => _reviewDetailsVM; set { _reviewDetailsVM = value; OnPropertyChanged(nameof(ReviewDetailsVM)); } }
    private ICommand _onLeft;
    private ICommand _onRight;
    private ICommand _onSave;
    private ICommand _takePhotoCommand;
    private ICommand _deletePhotoCommand;

    public ICommand TakePhotoCommand { get => _takePhotoCommand; set { _takePhotoCommand = value; OnPropertyChanged(nameof(TakePhotoCommand)); } }
    public ICommand OnLeft { get => _onLeft; set { _onLeft = value; OnPropertyChanged(nameof(OnLeft)); } }
    public ICommand OnRight { get => _onRight; set { _onRight = value; OnPropertyChanged(nameof(OnRight)); } }
    public ICommand OnSave { get => _onSave; set { _onSave = value; OnPropertyChanged(nameof(OnSave)); } }
    public ICommand DeletePhotoCommand { get => _deletePhotoCommand; set { _deletePhotoCommand = value; OnPropertyChanged(nameof(DeletePhotoCommand)); } }
    private readonly IBeeService _beeService;
    private readonly IViewModelsFactory _viewModelsFactory;
    private readonly IDataToSaveFactory _dataToSaveFactory;
    private readonly IUpdateDataHelper _updateDataHelper;
    private readonly IReviewHelper _reviewHelper;
    private readonly IPhotoHelper _photoHelper;
    public ReviewDetailsMainPage(IBeeService beeService, IViewModelsFactory viewModelsFactory, IDataToSaveFactory dataToSaveFactory,
        IUpdateDataHelper updateDataHelper, IReviewHelper reviewHelper, IPhotoHelper photoHelper)
    {
        _beeService = beeService;
        _viewModelsFactory = viewModelsFactory;
        _dataToSaveFactory = dataToSaveFactory;
        _updateDataHelper = updateDataHelper;
        _reviewHelper = reviewHelper;
        _photoHelper = photoHelper;
        InitializeComponent();
        InitializeCommand();

    }

    private void InitializeCommand()
    {
        OnLeft = new Command<DescriptionHiveReviewVM>(OnLeftClicked);
        OnRight = new Command<DescriptionHiveReviewVM>(OnRightClicked);
        OnSave = new Command(OnSaveClicked);
        DeletePhotoCommand = new Command<PhotoVM>(DeletePhotoClicked);
        TakePhotoCommand = new Command(async () => await TakeAndSavePhotoAsync());
    }

    private void DeletePhotoClicked(PhotoVM photoVM)
    {
        ReviewDetailsVM.SelectedItem.Photos.Remove(photoVM);
    }

    private async Task TakeAndSavePhotoAsync()
    {
        byte[] bytes = await _photoHelper.TakePhotoBytesAsync();
        if (bytes != null)
        {
            ReviewDetailsVM.SelectedItem.Photos.Add(new PhotoVM() { ImageData = bytes });
            //PhotoCV.ItemsSource = ReviewDetailsVM.SelectedItem.Photos;
        }
    }

    private void OnLeftClicked(DescriptionHiveReviewVM descriptionHiveReviewVM)
    {
        if (descriptionHiveReviewVM == null)
        {
            return;
        }
        int idx = ReviewDetailsVM.DescriptionHiveReviewVMs.IndexOf(descriptionHiveReviewVM);
        int previouseIdx = (idx - 1) < 0 ? ReviewDetailsVM.DescriptionHiveReviewVMs.Count - 1 : (idx - 1);
        ReviewDetailsVM.SelectedItem = ReviewDetailsVM.DescriptionHiveReviewVMs[previouseIdx];
    }
    private void OnRightClicked(DescriptionHiveReviewVM descriptionHiveReviewVM)
    {
        if (descriptionHiveReviewVM == null)
        {
            return;
        }
        int idx = ReviewDetailsVM.DescriptionHiveReviewVMs.IndexOf(descriptionHiveReviewVM);
        int nextIdx = (idx + 1) % ReviewDetailsVM.DescriptionHiveReviewVMs.Count;
        ReviewDetailsVM.SelectedItem = ReviewDetailsVM.DescriptionHiveReviewVMs[nextIdx];
    }
    private async void OnSaveClicked(object @object)
    {
        if (ReviewDetailsVM?.SelectedItem != null)
        {
            AddOrUpdateDescription(ReviewDetailsVM.SelectedItem);
        }

        bool allDescribed = ReviewDetailsVM.DescriptionHiveReviewVMs.All(x => x.DescriptionHiveReview.Description != null);
        if (allDescribed)
        {
            _reviewHelper.CompleateReview(_review);
            MessageCenter.RefresReviewList();
            await Navigation.PopAsync();
        }
        else
        {
            await this.DisplayAlert(
                            LocalizeManager.Translate("txt_InvalidReview"),
                            LocalizeManager.Translate("txt_UncompletedAllReview"),
                            LocalizeManager.Translate("txt_OK")
                        );
        }
    }

    public void InitializeData(Data.Core.Models.Review review)
    {
        _review = review;
        LoadData();
    }

    private void LoadData()
    {
        ReviewDetailsVM = _viewModelsFactory.CreateReviewDetailsVM(_review);
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await Task.Delay(1);
        SetFirstReview();
    }

    private void SetFirstReview()
    {
        if (ReviewDetailsVM != null && ReviewDetailsVM.SelectedItem == null)
        {
            ReviewDetailsCV.SelectedItem = ReviewDetailsVM.DescriptionHiveReviewVMs.FirstOrDefault();
            //ReviewDetailsVM.SelectedItem = ReviewDetailsVM.DescriptionHiveReviewVMs.FirstOrDefault();
        }
    }

    private void ReviewDetailsCV_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var previous = e.PreviousSelection.FirstOrDefault() as DescriptionHiveReviewVM;
        if (previous == null || previous.Description.IsNEoWS())
            return;
        AddOrUpdateDescription(previous);
    }

    private void AddOrUpdateDescription(DescriptionHiveReviewVM descriptionHiveReviewVM)
    {
        Description description = descriptionHiveReviewVM.DescriptionHiveReview.Description;
        try
        {
            if (description == null)
            {
                description = _dataToSaveFactory.CreateDescription(descriptionHiveReviewVM);
                descriptionHiveReviewVM.DescriptionHiveReview.Description = description;
                _beeService.UpdateDescriptionHiveReview(descriptionHiveReviewVM.DescriptionHiveReview);
                //_beeService.AddDescription(description);
            }
            else if (description.Text != descriptionHiveReviewVM.Description 
                || !description.Photos.SequenceEqual(descriptionHiveReviewVM.Photos.Select(x => x.Photo).ToList()))
            {
                description = _updateDataHelper.UpdateDescription(ref description, descriptionHiveReviewVM);
                _beeService.UpdateDescription(description);
            }
        }
        catch (Exception e)
        {
            throw e;
        }
    }
}