namespace Demo.DemoCBIA.Pages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    private async void SettingsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        string selectedItem = e.SelectedItem as string;
        await NavigateToSettings(selectedItem);

        // Deselect item
        SettingsListView.SelectedItem = null;
    }

    private async Task NavigateToSettings(string selectedItem)
    {
        switch (selectedItem)
        {
            case "General":
                await Navigation.PushAsync(new GeneralSettingsPage());
                break;
            case "Notifications":
                await Navigation.PushAsync(new NotificationsPage());
                break;
                // Add more cases for other settings pages if needed
        }
    }
}