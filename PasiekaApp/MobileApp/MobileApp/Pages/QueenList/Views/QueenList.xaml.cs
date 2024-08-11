using MobileApp.ViewModels;

namespace MobileApp.Pages.QueenList.Views;

public partial class QueenList : ContentView
{
    public static readonly BindableProperty QueenListVMsProperty =
        BindableProperty.Create(nameof(QueenListVMs), typeof(IEnumerable<QueenListVM>), typeof(QueenList), propertyChanged: OnQueenListVMsChanged);
    private static void OnQueenListVMsChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (QueenList)bindable;
        control.listVMs.ItemsSource = (IEnumerable<QueenListVM>)newValue;
    }

    public IEnumerable<QueenListVM> QueenListVMs
    {
        get => (IEnumerable<QueenListVM>)GetValue(QueenListVMsProperty);
        set => SetValue(QueenListVMsProperty, value);
    }

    public event EventHandler<SelectionChangedEventArgs> SelectionChanged;
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