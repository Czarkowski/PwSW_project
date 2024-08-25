using Data.Core.Models;
using MobileApp.ViewModels.PickerItems.Interfaces;
using System.Collections.Generic;

namespace MobileApp.Controls.CompositeControls;

public partial class CustomPicker2 : ContentView
{
    public static readonly BindableProperty OptionListProperty =
        BindableProperty.Create(nameof(OptionList), typeof(IEnumerable<IPickerItem>), typeof(CustomPicker2), null, propertyChanged: OnOptionListChanged);

    private static void OnOptionListChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var @this = (CustomPicker2)bindable;
        @this.UpdatePickerItems();
    }

    private void UpdatePickerItems()
    {
        if (Picker != null)
        {
            Picker.ItemsSource = (System.Collections.IList)OptionList;
        }
    }

    public IEnumerable<IPickerItem> OptionList
    {
        get => (IEnumerable<IPickerItem>)GetValue(OptionListProperty);
        set => SetValue(OptionListProperty, value);
    }


    public static readonly BindableProperty LabelTextProperty =
    BindableProperty.Create(nameof(LabelText), typeof(string), typeof(CustomPicker2), string.Empty, propertyChanged: OnTitleChanged);

    private static void OnTitleChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var @this = (CustomPicker2)bindable;
        @this.UpdatePickerItems();
        @this.Label.Text = (string)newValue;
    }

    public string LabelText
    {
        get => (string)GetValue(LabelTextProperty);
        set => SetValue(LabelTextProperty, value);
    }

    public static readonly BindableProperty SelectedItemProperty =
        BindableProperty.Create(nameof(SelectedItem), typeof(object), typeof(CustomPicker2), null, BindingMode.TwoWay);

    public object SelectedItem
    {
        get => (object)GetValue(SelectedItemProperty);
        set => SetValue(SelectedItemProperty, value);
    }

    public IPickerItem SelectedPickerItem
    {
        set => SelectedItem = value.Value;
        get => OptionList.FirstOrDefault(x => x.Value == SelectedItem);
    }

    public CustomPicker2()
	{
		InitializeComponent();
	}
	public void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        // Logika dla zmiany wyboru
    }
}