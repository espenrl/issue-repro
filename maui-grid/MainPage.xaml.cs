namespace maui_grid;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
    }

    private async void DelayShowButton()
    {
        await Task.Delay(TimeSpan.FromSeconds(1));
        Button.IsVisible = true;
    }
}
