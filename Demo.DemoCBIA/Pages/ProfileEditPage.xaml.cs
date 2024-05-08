using Demo.DemoCBIA.Models;
using Demo.DemoCBIA.ViewModels;

namespace Demo.DemoCBIA.Pages;

public partial class ProfileEditPage : ContentPage
{
    private ProfileViewModel _viewModel;
    public ProfileEditPage(ProfileViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }



    // If you have Save button on this page, you might want to handle the save action here
    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var imageSource = editImage.Source;
        string imageSourceString = ConvertImageSourceToString(imageSource);
        var profile = new ProfileInfo
        {
            Name = editName.Text,
            Email = editEmail.Text,
            PhoneNumber = editPhoneno.Text,
            DateOfBirth = (DateTime)editDOB.Date,
            Address = editAddress.Text,
            Gender = (string)editGender.SelectedItem,
            BloodGroup = editBG.Text,
            DietaryPreference = (string)editDietaryPreference.SelectedItem,
            EmergencyContactName = editEmergencyContactName.Text,
            EmergencyPhoneNumber = editEmergencyPhoneno.Text,
            EmergencyContactRelationship = editEmergencyRelation.Text,
            ImageSource = imageSourceString,
        };
        var viewModel = (ProfileViewModel)BindingContext;
        // Call the method to save the updated profile
        viewModel.UpdateProfile(profile);

        // Optionally navigate back to the previous page
        await Shell.Current.GoToAsync("//ProfilePage");
    }

    private string ConvertImageSourceToString(ImageSource imageSource)
    {
        // Implement logic to convert ImageSource to a string representation
        // For example, if ImageSource is a FileImageSource, you can extract the file path
        if (imageSource is FileImageSource fileImageSource)
        {
            return fileImageSource.File;
        }
        else if (imageSource is UriImageSource uriImageSource)
        {
            return uriImageSource.Uri.AbsoluteUri;
        }
        else
        {
            // Handle other types of ImageSource as needed
            return null;
        }
    }
}