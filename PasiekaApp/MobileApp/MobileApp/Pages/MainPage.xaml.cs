using Microsoft.Maui.Controls;

namespace MobileApp.Pages
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(IServiceProvider serviceProvider)
        {
            InitializeComponent();
        }

        //public void NavigateTo(Page page)
        //{
        //    contentView.Content = page.Content;
        //}
    }

}
