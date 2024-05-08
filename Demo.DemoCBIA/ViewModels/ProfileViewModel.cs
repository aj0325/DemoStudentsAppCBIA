using Demo.DemoCBIA.Models;
using System.ComponentModel;
using System.Text.Json;

namespace Demo.DemoCBIA.ViewModels
{
    public class ProfileViewModel : INotifyPropertyChanged
    {
        private string jsonData = @"{
        ""Name"": ""John"",
        ""LastName"": ""Doe"",
        ""Email"": ""abc@gmail.com"",
        ""PhoneNumber"": ""123456789"",
        ""DateOfBirth"": ""2000-01-01T09:00:00Z"",
        ""Address"": ""House no. 4, 12th Street"",
        ""Gender"": ""Male"",
        ""BloodGroup"": ""O+"",
        ""DietaryPreference"": ""Vegetarian"",
        ""EmergencyContactName"": ""Jay"",
        ""EmergencyPhoneNumber"": ""123456789"",
        ""EmergencyContactRelationship"": ""Dad"",
        ""ImageSource"": ""profile_image_male.png""

        }";



        //public ProfileInfo Profile { get; set; }
        private ProfileInfo _profile;
        public ProfileInfo Profile
        {
            get { return _profile; }
            set
            {
                if (_profile != value)
                {
                    _profile = value;
                    OnPropertyChanged(nameof(Profile));
                }
            }
        }



        public ProfileViewModel()
        {
            LoadProfileFromJson();
        }

        private void LoadProfileFromJson()
        {
            Profile = JsonSerializer.Deserialize<ProfileInfo>(jsonData);
            // In a real application, you might want to load jsonData from a file or database.
            // For this example, jsonData is simply a string.
        }

        public void UpdateProfile(ProfileInfo updatedProfile)
        {
            Profile = updatedProfile;
            SaveProfileToJson();
        }

        private void SaveProfileToJson()
        {
            jsonData = JsonSerializer.Serialize(Profile);
            //LoadProfileFromJson();
            // In a real application, you might want to save jsonData to a file or database.
            // For this example, jsonData is simply updated in memory.
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
