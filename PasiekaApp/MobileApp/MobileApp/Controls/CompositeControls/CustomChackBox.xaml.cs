namespace MobileApp.Controls.CompositeControls;

public partial class CustomChackBox : ContentView
{
    public static readonly BindableProperty LabelTextProperty =
    BindableProperty.Create(nameof(LabelText), typeof(string), typeof(CustomChackBox), string.Empty, propertyChanged: OnLabelTextChanged);

    private static void OnLabelTextChanged(BindableObject bindable, object oldValue, object newValue)
    {
    }

    public string LabelText
    {
        get => (string)GetValue(LabelTextProperty);
        set => SetValue(LabelTextProperty, value);
    }

    public static readonly BindableProperty IsCheckedProperty =
        BindableProperty.Create(nameof(IsChecked), typeof(bool), typeof(CustomChackBox), false, BindingMode.TwoWay, propertyChanged: OnIsCheckedChanged);

    private static void OnIsCheckedChanged(BindableObject bindable, object oldValue, object newValue)
    {
    }

    public bool IsChecked
    {
        get => (bool)GetValue(IsCheckedProperty);
        set => SetValue(IsCheckedProperty, value);
    }


    public CustomChackBox()
	{
		InitializeComponent();
	}
}