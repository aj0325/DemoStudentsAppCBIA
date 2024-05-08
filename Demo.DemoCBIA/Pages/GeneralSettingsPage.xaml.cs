namespace Demo.DemoCBIA.Pages;

public partial class GeneralSettingsPage : ContentPage
{
	public GeneralSettingsPage()
	{
		InitializeComponent();
        BindingContext = this;

        //ThemeManager.SelectedThemeChanged += ThemeManager_SelectedThemeChanged;
    }

    //private void ThemeManager_SelectedThemeChanged(object sender, EventArgs e)
    //{
    //    SelectedTheme = ThemeManager.SelectedTheme;
    //}

    //private string _selectedTheme = ThemeManager.SelectedTheme;
    //public string SelectedTheme
    //{
    //    get => _selectedTheme;
    //    set
    //    {
    //        if (value != _selectedTheme)
    //        {
    //            _selectedTheme = value;
    //            OnPropertyChanged(nameof(SelectedTheme));
    //        }
    //    }
    //}

    //private void Button_Clicked(object sender, EventArgs e)
    //{
    //    ThemeManager.SetTheme(nameof(Demo.DemoCBIA.Resources.Themes.Light));
    //}

    //private async void Button_Clicked_1(object sender, EventArgs e)
    //{
    //    var newTheme = await DisplayActionSheet("Choose Theme", "Cancel", null, ThemeManager.ThemeNames);
    //    if (!string.IsNullOrWhiteSpace(newTheme) && newTheme != "Cancel")
    //    {
    //        ThemeManager.SetTheme(newTheme);
    //    }
    //}


    private void SetLightTheme()
    {
        Application.Current.Resources["BackgroundColor"] = Application.Current.Resources["LightBackgroundColor"];
        Application.Current.Resources["TextColor"] = Application.Current.Resources["LightTextColor"];
    }

    private void SetDarkTheme()
    {
        Application.Current.Resources["BackgroundColor"] = Application.Current.Resources["DarkBackgroundColor"];
        Application.Current.Resources["TextColor"] = Application.Current.Resources["DarkTextColor"];
    }
}