using Data.Core.Models;
using MobileApp.PickerItems.Interfaces;
using MobileApp.StaticResources;
using System.Collections.Generic;
using Utilities.StaticExtensions;

namespace MobileApp.Controls.CompositeControls;

public partial class CustomPicker : ContentView
{
    public static readonly BindableProperty OptionListProperty =
        BindableProperty.Create(nameof(OptionList), typeof(IEnumerable<object>), typeof(CustomPicker), null, propertyChanged: OnOptionListChanged);

    private static void OnOptionListChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var @this = (CustomPicker)bindable;
        //@this.UpdatePickerItems();
    }

    //private void UpdatePickerItems()
    //{
    //    if (Picker != null)
    //    {
    //        Picker.ItemsSource = (System.Collections.IList)OptionList;
    //    }
    //}


    public IEnumerable<object> OptionList
    {
        get => (IEnumerable<object>)GetValue(OptionListProperty);
        set => SetValue(OptionListProperty, value);
    }

    public static readonly BindableProperty DisplayPropertyProperty =
        BindableProperty.Create(
            nameof(DisplayProperty),
            typeof(string),
            typeof(CustomPicker),
            null, // Domyœlnie null
            propertyChanged: OnItemDisplayBindingPropertyChanged);

    public string DisplayProperty
    {
        get => (string)GetValue(DisplayPropertyProperty);
        set => SetValue(DisplayPropertyProperty, value);
    }

    //private static void OnDisplayPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    //{
    //    var picker = (CustomPicker)bindable;
    //    //picker.UpdateItemDisplayBinding();
    //}

    //private void UpdateItemDisplayBinding()
    //{
    //    if (string.IsNullOrWhiteSpace(DisplayProperty))
    //    {
    //        // Reset ItemDisplayBinding to null, to use ToString()
    //        Picker.ItemDisplayBinding = null;
    //    }
    //    else
    //    {
    //        // Set ItemDisplayBinding to the specified property
    //        Picker.ItemDisplayBinding = new Binding(DisplayProperty);
    //    }
    //}

    public static readonly BindableProperty ItemDisplayBindingProperty =
        BindableProperty.Create(
        nameof(ItemDisplayBinding),
        typeof(BindingBase),
        typeof(CustomPicker),
        null, // Domyœlnie null
        propertyChanged: OnItemDisplayBindingPropertyChanged);

    public BindingBase ItemDisplayBinding
    {
        get => (BindingBase)GetValue(ItemDisplayBindingProperty);
        set => SetValue(ItemDisplayBindingProperty, value);
    }


    public static readonly BindableProperty ItemDisplayConverterProperty =
        BindableProperty.Create(
            nameof(ItemDisplayConverter),
            typeof(IValueConverter),
            typeof(CustomPicker),
            null, // Domyœlnie null
            propertyChanged: OnItemDisplayBindingPropertyChanged);

    public IValueConverter ItemDisplayConverter
    {
        get => (IValueConverter)GetValue(ItemDisplayConverterProperty);
        set => SetValue(ItemDisplayConverterProperty, value);
    }

    private static void OnItemDisplayBindingPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var picker = (CustomPicker)bindable;
        picker.UpdateItemDisplayBinding();
    }

    private void UpdateItemDisplayBinding()
    {
        Picker.ItemDisplayBinding = new Binding(DisplayProperty.IsNEoWS() ? "." : DisplayProperty, converter: ItemDisplayConverter);
    }

    //public static readonly BindableProperty DisplayMemberProperty =
    //BindableProperty.Create(nameof(DisplayMember), typeof(Func<object, string>), typeof(CustomPicker), null);

    //public Func<object, string> DisplayMember
    //{
    //    get => (Func<object, string>)GetValue(DisplayMemberProperty) ?? ((x) => x?.ToString() ?? string.Empty);
    //    set => SetValue(DisplayMemberProperty, value);
    //}


    public static readonly BindableProperty LabelTextProperty =
    BindableProperty.Create(nameof(LabelText), typeof(string), typeof(CustomPicker), string.Empty, propertyChanged: OnTitleChanged);

    private static void OnTitleChanged(BindableObject bindable, object oldValue, object newValue)
    {
        //var @this = (CustomPicker)bindable;
        //@this.UpdatePickerItems();
        //@this.Label.Text = (string)newValue;
    }

    public string LabelText
    {
        get => (string)GetValue(LabelTextProperty);
        set => SetValue(LabelTextProperty, value);
    }

    public static readonly BindableProperty SelectedItemProperty =
        BindableProperty.Create(nameof(SelectedItem), typeof(object), typeof(CustomPicker), null, BindingMode.TwoWay);

    public object SelectedItem
    {
        get => (object)GetValue(SelectedItemProperty);
        set => SetValue(SelectedItemProperty, value);
    }

    public CustomPicker()
	{
		InitializeComponent();
        //Picker.ItemDisplayBinding = new Binding(nameof(DisplayMember));
	}
	public void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        // Logika dla zmiany wyboru
    }
}