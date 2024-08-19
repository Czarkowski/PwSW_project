using MobileApp.ViewModels;

namespace MobileApp.Pages.QueenList.Views;

public partial class QueenList : ContentView
{
    public static readonly BindableProperty QueenListVMsProperty =
        BindableProperty.Create(nameof(QueenListVMs), typeof(IList<QueenListVM>), typeof(QueenList), propertyChanged: OnQueenListVMsChanged);
    private static void OnQueenListVMsChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (QueenList)bindable;
        control.listVMs.ItemsSource = (IList<QueenListVM>)newValue;
    }

    public IList<QueenListVM> QueenListVMs
    {
        get => (IList<QueenListVM>)GetValue(QueenListVMsProperty);
        set => SetValue(QueenListVMsProperty, value);
    }

    public event EventHandler<SelectionChangedEventArgs> SelectionChanged;

    public event EventHandler<SelectionChangedEventArgs> ItemSelected;
    public QueenList()
	{
		InitializeComponent();

        //LoadList();
	}

    //private void LoadList()
    //{
    //    listVMs.ItemsSource = QueenListVMs;
    //}

    private void OnItemSelected(object sender, SelectionChangedEventArgs e)
    {
        SelectionChanged?.Invoke(this, e);
    }

}