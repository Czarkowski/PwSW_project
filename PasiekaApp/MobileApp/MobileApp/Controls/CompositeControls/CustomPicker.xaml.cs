using MobileApp.PickerItems.Interfaces;
using MobileApp.StaticResources;

namespace MobileApp.Controls.CompositeControls;

public partial class CustomPicker : ContentView
{
    public static readonly BindableProperty OptionListProperty =
        BindableProperty.Create(nameof(OptionList), typeof(IEnumerable<IPickerItem>), typeof(CustomPicker), null, propertyChanged: OnOptionListChanged);

    private static void OnOptionListChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var picker = (CustomPicker)bindable;
        picker.UpdatePickerItems();
    }

    private void UpdatePickerItems()
    {
        //if (picker != null)
        //{
        //    picker.ItemsSource = OptionList;
        //}
    }

    public IEnumerable<IPickerItem> OptionList
    {
        get => (IEnumerable<IPickerItem>)GetValue(OptionListProperty);
        set => SetValue(OptionListProperty, value);
    }


    public static readonly BindableProperty TitleProperty =
    BindableProperty.Create(nameof(Title), typeof(string), typeof(CustomPicker), string.Empty);

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public CustomPicker()
	{
        this.BindingContext = this;
		InitializeComponent();
	}
	public void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        // Logika dla zmiany wyboru
    }
}