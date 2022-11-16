namespace arcgis_runtime_maui_v200_beta;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync(nameof(MapPage));
    }
}
