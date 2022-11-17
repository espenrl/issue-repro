using System.Collections.ObjectModel;

namespace CarouselView_android_recycled_bitmap;

public record Item(string Link);

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
        CarouselView.ItemsSource = _items;
    }

	private readonly ObservableCollection<Item> _items = new()
    {
        new Item("https://news.microsoft.com/wp-content/uploads/prod/2022/11/Viva-Sales.jpg"),
        new Item("https://news.microsoft.com/wp-content/uploads/prod/2022/11/Viva-Connection-homepage-half-with-partners.jpg"),
        new Item("https://news.microsoft.com/wp-content/uploads/prod/2022/11/Amplify-campaign-creation-Teams.jpg"),
        new Item("https://news.microsoft.com/wp-content/uploads/prod/2022/11/Org-Explorer-Team-Goals.jpg"),
        new Item("https://news.microsoft.com/wp-content/uploads/prod/2022/11/MSFT_WTI_VIVA_Article_IG1.jpg"),
    };
}

