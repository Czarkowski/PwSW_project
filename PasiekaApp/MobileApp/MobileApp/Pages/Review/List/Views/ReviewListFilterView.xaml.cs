using MobileApp.Controls.CompositeControls;
using System.Windows.Input;

namespace MobileApp.Pages.Review.List.Views;

public partial class ReviewListFilterView : ContentView
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

    public ReviewListFilterView()
	{
		InitializeComponent();
	}

    private void Search_Clicked(object sender, EventArgs e)
    {

    }
}