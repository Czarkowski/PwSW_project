namespace MobileApp.Controls.CompositeControls;

public partial class CustomDatePicker : ContentView
{
	public static readonly BindableProperty SelectedDateProperty =
        BindableProperty.Create(nameof(SelectedDate), typeof(DateTime), typeof(CustomDatePicker), DateTime.Now.Date, BindingMode.TwoWay, propertyChanged: OnDateChanged);
    private static void OnDateChanged(BindableObject bindable, object oldValue, object newValue)
    {
    }

    public DateTime SelectedDate
    {
        get => (DateTime)GetValue(SelectedDateProperty);
        set => SetValue(SelectedDateProperty, value);
    }



    public static readonly BindableProperty LabelTextProperty =
        BindableProperty.Create(nameof(LabelText), typeof(string), typeof(LabelEntry), string.Empty, propertyChanged: OnLabelTextChanged);

    private static void OnLabelTextChanged(BindableObject bindable, object oldValue, object newValue)
    {
    }

    public string LabelText
    {
        get => (string)GetValue(LabelTextProperty);
        set => SetValue(LabelTextProperty, value);
    }

    public CustomDatePicker()
	{
		InitializeComponent();
	}
}