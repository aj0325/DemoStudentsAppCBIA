using Demo.DemoCBIA.Services;
using Demo.DemoCBIA.ViewModels;
namespace Demo.DemoCBIA.Pages;

public partial class LoginPage : ContentPage
{
    private readonly LoginViewModel _viewModel;

	public LoginPage()
	{
        _viewModel = new LoginViewModel(new MockAuthenticationService());
        BindingContext = _viewModel;
        //BindingContext = ViewModel;
        InitializeComponent();
        IsInitialized = true;
    }

    //LoginViewModel ViewModel { get; }
    bool IsInitialized { get; }

    async void OnLoginClicked(object sender, EventArgs e)
    {
        var username = userIdEdit.Text;
        var password = passwordEdit.Text;
        bool isAuthenticated = await _viewModel.AuthenticateAsync(username, password);
        if (isAuthenticated)
        {
            // Navigate to the main page
            await Shell.Current.GoToAsync("//MainPage");
        }
        else
        {
            // Display error message
            // For example:
            await DisplayAlert("Error", "Invalid username or password", "OK");
        }
        //await Shell.Current.Navigation.PopToRootAsync();
        //await Shell.Current.GoToAsync("//MainPage");
    }

    void OnTextEditTextChanged(System.Object sender, System.EventArgs e)
    {
        if (IsLoaded)
        {
            _viewModel.ValidateEditors();
        }
    }
}