using Demo.DemoCBIA.Models;
using Demo.DemoCBIA.ViewModels;

namespace Demo.DemoCBIA.Pages;

public partial class TripsPage : ContentPage
{
	public TripsPage()
	{
		InitializeComponent();
        
        BindingContext = new TripsViewModel();
    }
    private async void OnFillFormButtonClicked(object sender, EventArgs e)
    {
        var viewModel = (TripsViewModel)BindingContext;
        // Navigate to the GoingAwayFormPage
        await Navigation.PushAsync(new GoingAwayForm(viewModel));
    }
}
