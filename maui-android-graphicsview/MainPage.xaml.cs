namespace maui_android_graphicsview;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Cross.IsVisible = !Cross.IsVisible;
    }
}
