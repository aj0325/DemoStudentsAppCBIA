namespace Demo.DemoCBIA.Pages;

public partial class CityPage : ContentPage
{
	public CityPage()
	{
		InitializeComponent();
	}
    private async void MapButton_Clicked(object sender, EventArgs e)
    {
        //await DisplayAlert("Clicked on maps", "Navigating to Map", "OK");
        await Navigation.PushAsync(new MapPage());
    }

    private async void HandbookButton_Clicked(object sender, EventArgs e)
    {
        //await DisplayAlert("Clicked on pdf", "Navigating to pdf", "OK");
        await Navigation.PushAsync(new cityhandbook("mumbai_handbook.pdf"));
    }
}