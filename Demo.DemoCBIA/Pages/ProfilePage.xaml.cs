using System.Xml;
using DevExpress.Maui.DataForm;
using Demo.DemoCBIA.Models;
using Demo.DemoCBIA.ViewModels;
namespace Demo.DemoCBIA.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
        //dataform.DataObject = new PersonalInfo();
        BindingContext = new ProfileViewModel();
    }

    
    private async void EditButton_Clicked(object sender, EventArgs e)
    {
        var viewModel = (ProfileViewModel)BindingContext;
        // Navigate to the GoingAwayFormPage
        await Navigation.PushAsync(new ProfileEditPage(viewModel));
        
    }

}