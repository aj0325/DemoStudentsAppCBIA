using Demo.DemoCBIA.Models;

namespace Demo.DemoCBIA.Pages;

public partial class AccomodationsPage : ContentPage
{
	public AccomodationsPage()
	{
		InitializeComponent();
        var accommodationDetails = new AccommodationDetails
        {
            RoomNumber = "101",
            BuildingName = "Main Building",
            Floor = "1st Floor",
            IsSingleOccupancy = false,
            NumberOfRoommates = 2,
            RoommateNames = {"Jack Kline", "Jane Smith"}
        };
        

        BindingContext = accommodationDetails;
    }
}