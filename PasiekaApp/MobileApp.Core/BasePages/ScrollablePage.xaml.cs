namespace MobileApp.Core.BasePages;

public partial class ScrollablePage : ContentPage
{
    private readonly ScrollView _scrollView;
    private readonly VerticalStackLayout _stackLayout;
    public ScrollablePage()
	{
		InitializeComponent();
        _stackLayout = new VerticalStackLayout
        {
            Padding = new Thickness(20)
        };

        _scrollView = new ScrollView
        {
            Content = _stackLayout
        };

        Content = _scrollView;
    }

    public new View Content
    {
        get => PageContent.Content;
        set => PageContent.Content = value;
    }
}