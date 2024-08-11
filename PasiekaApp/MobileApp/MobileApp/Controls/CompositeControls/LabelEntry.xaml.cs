namespace MobileApp.Controls.CompositeControls;

public partial class LabelEntry : ContentView
{
    public static readonly BindableProperty LabelTextProperty =
            BindableProperty.Create(nameof(LabelText), typeof(string), typeof(LabelEntry), string.Empty);

    public string LabelText
    {
        get => (string)GetValue(LabelTextProperty);
        set => SetValue(LabelTextProperty, value);
    }

    public static readonly BindableProperty EntryTextProperty =
        BindableProperty.Create(nameof(EntryText), typeof(string), typeof(LabelEntry), string.Empty, BindingMode.TwoWay);

    public string EntryText
    {
        get => (string)GetValue(EntryTextProperty);
        set => SetValue(EntryTextProperty, value);
    }
    public LabelEntry()
	{
		InitializeComponent();
        this.BindingContext = this;
	}
}