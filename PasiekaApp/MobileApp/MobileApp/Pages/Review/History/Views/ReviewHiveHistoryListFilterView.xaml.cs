using MobileApp.Pages.Review.List.Views;
using System.Windows.Input;

namespace MobileApp.Pages.Review.History.Views;

public partial class ReviewHiveHistoryListFilterView : ContentView
{
    public static readonly BindableProperty OnSearchProperty =
    BindableProperty.Create(nameof(OnSearch), typeof(ICommand), typeof(ReviewListFilterView), null, propertyChanged: OnSearchChanged);

    private static void OnSearchChanged(BindableObject bindable, object oldValue, object newValue)
    {
    }

    public ICommand OnSearch
    {
        get => (ICommand)GetValue(OnSearchProperty);
        set => SetValue(OnSearchProperty, value);
    }
    public ReviewHiveHistoryListFilterView()
	{
		InitializeComponent();
	}
}