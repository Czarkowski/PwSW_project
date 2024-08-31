

namespace MobileApp.Controls.CompositeControls;

public partial class LabelEntry : ContentView
{
    public static readonly BindableProperty LabelTextProperty =
        BindableProperty.Create(nameof(LabelText), typeof(string), typeof(LabelEntry), string.Empty, propertyChanged: OnLabelTextChanged);

    private static void OnLabelTextChanged(BindableObject bindable, object oldValue, object newValue)
    {
        //var @this = (LabelEntry)bindable;
        //@this.labelText.Text = (string)newValue;
    }

    public string LabelText
    {
        get => (string)GetValue(LabelTextProperty);
        set => SetValue(LabelTextProperty, value);
    }

    public static readonly BindableProperty EntryTextProperty =
        BindableProperty.Create(nameof(EntryText), typeof(string), typeof(LabelEntry), string.Empty, defaultBindingMode : BindingMode.TwoWay,
            propertyChanged: OnEntryTextChanged);

    private static void OnEntryTextChanged(BindableObject bindable, object oldValue, object newValue)
    {
        //var @this = (LabelEntry)bindable;
        //@this.entryText.Text = (string)newValue;
    }

    public string EntryText
    {
        get => (string)GetValue(EntryTextProperty);
        set => SetValue(EntryTextProperty, value);
    }
    public LabelEntry()
	{
		InitializeComponent();
        //this.BindingContext = this;
	}

    public Entry GetEntry => this.Entry;
}