using Demo.DemoCBIA.ViewModels;
using DevExpress.XtraSpellChecker.Parser;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace Demo.DemoCBIA.Pages;

public partial class ResourcesMapPage : ContentPage
{
        public ResourcesMapPage(string buildingName)
        {
            InitializeComponent();

            // Initialize the ViewModel with the building name
            BindingContext = new ResourcesMapViewModel(buildingName);
        map.MoveToRegion(MapSpan.FromCenterAndRadius(
                    new Location(48.783333, 3.416667), Distance.FromMiles(100)));
        // Set pins based on resources near the building
        SetPinsForNearbyResources();
        }

    private void Map_Clicked(object sender, Microsoft.Maui.Controls.Maps.MapClickedEventArgs e)
    {
        
    }

    private void SetPinsForNearbyResources()
        {
            // Get the ViewModel from the BindingContext
            if (BindingContext is ResourcesMapViewModel viewModel)
            {
                // Set pins based on the resources near the building
                // Add pins for restaurants
                foreach (var restaurant in viewModel.BuildingResources.Restaurants)
                {
                    var pin = new Pin
                    {
                        Label = restaurant.Name,
                        Location = new Location(restaurant.Location.Latitude, restaurant.Location.Longitude)
                    };
                    map.Pins.Add(pin);
                }

                // Add pins for hospitals
                foreach (var hospital in viewModel.BuildingResources.Hospitals)
                {
                    var pin = new Pin
                    {
                        Label = hospital.Name,
                        Location = new Location(hospital.Location.Latitude, hospital.Location.Longitude)
                    };
                    map.Pins.Add(pin);
                }
            }
        }
    }


