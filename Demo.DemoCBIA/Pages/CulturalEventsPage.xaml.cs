using Newtonsoft.Json;
using Demo.DemoCBIA.Models;
using DevExpress.Maui.DataGrid;
using Demo.ApiClient.Models.ApiModels;
using Demo.ApiClient.Models;
using Demo.ApiClient;

namespace Demo.DemoCBIA.Pages;

public partial class CulturalEventsPage : ContentPage
{
    //public List<CulturalEvent> Events { get; set; }
    //public CulturalEventsPage()
    //{
        //InitializeComponent();
        //Events = new List<CulturalEvent>
            //{
                //new CulturalEvent { Name = "Welcome Week Concert", Date = new DateTime(2024, 09, 07), Description = "Kick off the new academic year with an exciting concert featuring local bands and student performances.", SignedUp = true },
                //new CulturalEvent { Name = "International Food Festival", Date = new DateTime(2024, 10, 15), Description = "Experience a culinary journey around the world with delicious dishes prepared by international student clubs.", SignedUp = false },
                //new CulturalEvent { Name = "Winter Holiday Celebration", Date = new DateTime(2024, 12, 21), Description = "Celebrate the winter holidays with festive decorations, music, and seasonal treats.", SignedUp = true }
                // Add more cultural events as needed
            //};
        //BindingContext = this;

    //}

    private readonly DemoApiClientService _apiClient;

    public CulturalEventsPage(DemoApiClientService apiClient)
    {
        InitializeComponent();

        _apiClient = apiClient;

        var culturalEvents = _apiClient.GetCulturalEvents();
        culturalEventsDG.ItemsSource = culturalEvents;

        //LoadCulturalEvents();
    }

    private async void btnAdd_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AddEditCulturalEvent(_apiClient, null));
    }

    private async void btnShowCulturalEvents_Clicked(object sender, EventArgs e)
    {
        await LoadCulturalEvents();
    }

    private async void culturalEventListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var culturalEvent = (ApiClient.Models.ApiModels.CulturalEvent)e.Item;
        var action = await DisplayActionSheet("Action", "Cancel", null, "Edit", "Delete");

        switch (action)
        {
            case "Edit":
                await Navigation.PushModalAsync(new AddEditCulturalEvent(_apiClient, culturalEvent));
                break;
            case "Delete":
                await _apiClient.DeleteCulturalEvent(culturalEvent.Id);
                await LoadCulturalEvents();
                break;
        }
    }

    private async Task LoadCulturalEvents()
    {
        var culturalEvents = await _apiClient.GetCulturalEvents();
        culturalEventsDG.ItemsSource = culturalEvents;
    }

}