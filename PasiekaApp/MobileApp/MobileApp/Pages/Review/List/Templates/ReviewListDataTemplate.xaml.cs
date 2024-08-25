
using MobileApp.ViewModels;

namespace MobileApp.Pages.Review.List.Templates;

public partial class ReviewListDataTemplate : DataTemplate
{
	public ReviewListDataTemplate()
	{
		InitializeComponent();
        InitializeComponentParemeters();
    }

    private void InitializeComponentParemeters()
    {
        var view = (Grid)this.CreateContent();
        var realizedDateLabel = (Label)view.FindByName("RealizedDateLabel");

        if (realizedDateLabel != null)
        {
            // Modyfikacja w�a�ciwo�ci Label
            realizedDateLabel.TextColor = Colors.Red; // Na przyk�ad
        }
    }

}