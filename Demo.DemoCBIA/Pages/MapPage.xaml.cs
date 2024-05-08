using Demo.DemoCBIA.ViewModels;
using Microsoft.Maui.Controls.Maps;
using DevExpress.Maui.Controls;
using DevExpress.Maui.Core;

namespace Demo.DemoCBIA.Pages;

public partial class MapPage : ContentPage
{
	public MapPage()
	{
		InitializeComponent();
	}

    private void Map_Clicked(object sender, Microsoft.Maui.Controls.Maps.MapClickedEventArgs e)
    {

    }
    private void Pin_MarkerClicked(object sender, Microsoft.Maui.Controls.Maps.PinClickedEventArgs e)
    {
        ((MapViewModel)this.BindingContext).SelectedCity = (CityItem)((Pin)sender).BindingContext;
        bottomSheet.State = DevExpress.Maui.Controls.BottomSheetState.HalfExpanded;
        bottomSheet.HalfExpandedRatio = 0.6;

    }

    private void ActionButton_Clicked(object sender, EventArgs e)
    {
        if (sender is DXButton button)
        {
            // Retrieve the parameter passed to the event handler
            string actionName = button.CommandParameter as string;

            // Check if the "Restaurants" button was clicked
            if (actionName == "Restaurants")
            {
                // Access the DataContext (MapViewModel) of the page
                if (this.BindingContext is MapViewModel viewModel)
                {
                    DisplayAlert("Clicked", "Restaurant", "OK");
                    // Call the method to show restaurants
                    viewModel.ShowRestaurants();
                }
            }
            // Add more conditions for other action buttons if needed
        }
    }
}