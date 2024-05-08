using Demo.DemoCBIA.Models;

namespace Demo.DemoCBIA.Pages;

public partial class OrientationFilesPage : ContentPage
{
	public List<PdfModel> PdfModels { get; set; }
	public OrientationFilesPage()
	{
		InitializeComponent();
		PdfModels = new List<PdfModel>()
		{
			new PdfModel{Name = "Orientation Schedule", Path="sample-one-day-orientation-schedule.pdf"},
			new PdfModel{Name = "Handbook", Path="mumbai_handbook.pdf"}
		};
		BindingContext = this;
       
    }
    private async void OrientFileButton_Clicked(object sender, EventArgs e)
    {
        //await DisplayAlert("Clicked on maps", "Navigating to Map", "OK");
        await Navigation.PushAsync(new orientfilepage("Orientation-Guide.pdf"));
    }

    private async void HandbookButton_Clicked(object sender, EventArgs e)
    {
        //await DisplayAlert("Clicked on pdf", "Navigating to pdf", "OK");
        await Navigation.PushAsync(new cityhandbook("mumbai_handbook.pdf"));
    }


}