using Microsoft.Maui.Controls;

namespace MobileApp.Pages;

public partial class MenuPage : ContentView
{
    public MenuPage()
    {
        //InitializeComponent();
    }

    private void OnTab1Clicked(object sender, EventArgs e)
    {
        //((MainPage)App.Current.MainPage).NavigateTo(new Tab1Page());
    }

    private void OnTab2Clicked(object sender, EventArgs e)
    {
        //((MainPage)App.Current.MainPage).NavigateTo(new Tab2Page());
    }
}