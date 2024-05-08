using Demo.ApiClient;
using Demo.ApiClient.Models.ApiModels;
using System.Xml.Linq;

namespace Demo.DemoCBIA.Pages
{
    public partial class AddEditCulturalEvent : ContentPage
    {
        private readonly DemoApiClientService _apiClient;
        private CulturalEvent _culturalEvent;

        public AddEditCulturalEvent(DemoApiClientService apiClient, CulturalEvent culturalEvent)
        {
            InitializeComponent();

            _apiClient = apiClient;
            _culturalEvent = culturalEvent;
            LoadCulturalEventDetails();
        }

        private void LoadCulturalEventDetails()
        {
            if (_culturalEvent is not null)
            {
                txtName.Text = _culturalEvent.EventName;
                dpDate.Date = _culturalEvent.Date;
                txtDescription.Text = _culturalEvent.Description;
                swSignedUp.IsChecked = _culturalEvent.SignedUp;
            }
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            if (_culturalEvent is null)
            {
                // Add a new cultural event
                await _apiClient.SaveCulturalEvent(new CulturalEvent
                {
                    EventName = txtName.Text,
                    Date = dpDate.Date,
                    Description = txtDescription.Text,
                    SignedUp = swSignedUp.IsChecked
                });
            }
            else
            {
                // Update an existing cultural event
                await _apiClient.UpdateCulturalEvent(new CulturalEvent
                {
                    Id = _culturalEvent.Id,
                    EventName = txtName.Text,
                    Date = dpDate.Date,
                    Description = txtDescription.Text,
                    SignedUp = swSignedUp.IsChecked
                });
            }

            await Navigation.PopModalAsync();
        }

        private async void btnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
