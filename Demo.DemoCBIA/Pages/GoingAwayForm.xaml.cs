using Demo.DemoCBIA.Models;
using DevExpress.Maui.DataGrid;
using DevExpress.Maui.DataForm;
using Demo.DemoCBIA.ViewModels;
namespace Demo.DemoCBIA.Pages;

public partial class GoingAwayForm : ContentPage
{
    private TripsViewModel _viewModel;

    public GoingAwayForm(TripsViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        // Check if required fields are empty
        if (string.IsNullOrWhiteSpace(studentNameEntry.Text) ||
            string.IsNullOrWhiteSpace(studentIdEntry.Text) ||
            string.IsNullOrWhiteSpace(tripNameEntry.Text) ||
            string.IsNullOrWhiteSpace(phoneNumber.Text) ||
            string.IsNullOrWhiteSpace(destinationEntry.Text) ||
            string.IsNullOrWhiteSpace(purposeEditor.Text))
        {
            // Display an error message or highlight the fields
            await DisplayAlert("Error", "Please fill in all required fields.", "OK");
            return; // Stop further processing
        }
        var newTrip = new Trip
        {
            Name = tripNameEntry.Text,
            Location = destinationEntry.Text,
            DepartureDate = departureDate.Date,
            ReturnDate = returnDate.Date,
            GoingFormFilled = true,
            FullName = studentNameEntry.Text,
            StudentId = studentIdEntry.Text,
            PhoneNumber = phoneNumber.Text,
            
            Purpose = purposeEditor.Text,
        };

        _viewModel.AddTrip(newTrip);
        await DisplayAlert("Success", "Trip details added.", "OK");
        await Shell.Current.GoToAsync("//TripsPage");

    }
}