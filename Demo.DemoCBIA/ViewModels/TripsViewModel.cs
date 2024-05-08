using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Demo.DemoCBIA.Models;
namespace Demo.DemoCBIA.ViewModels
{
    public class TripsViewModel
    {
        private string jsonData = @"
        [
          {
            ""Name"": ""Trip 1"",
            ""GoingFormFilled"": true,
            ""FullName"": ""John"",
            ""StudentId"": ""123456"",
            ""PhoneNumber"": ""+1 (555) 123-4567"",
            ""Location"": ""Mountains"",
            ""DepartureDate"": ""2024-05-15T10:00:00Z"",
            ""ReturnDate"": ""2024-05-30T15:00:00Z"",
            ""Purpose"": ""Vacation""
          },
          {
            ""Name"": ""Trip 2"",
            ""GoingFormFilled"": true,
            ""FullName"": ""John"",
            ""StudentId"": ""123456"",
            ""PhoneNumber"": ""+1 (555) 765-4321"",
            ""Location"": ""Beach"",
            ""DepartureDate"": ""2024-06-20T08:00:00Z"",
            ""ReturnDate"": ""2024-07-05T20:00:00Z"",
            ""Purpose"": ""Sightseeing""
          },
          {
            ""Name"": ""Trip 3"",
            ""GoingFormFilled"": true,
            ""FullName"": ""John"",
            ""StudentId"": ""123456"",
            ""PhoneNumber"": ""+1 (555) 678-9012"",
            ""Location"": ""New York, USA"",
            ""DepartureDate"": ""2024-08-10T09:00:00Z"",
            ""ReturnDate"": ""2024-08-24T22:00:00Z"",
            ""Purpose"": ""Internship""
          }
        ]";
        public ObservableCollection<Trip> Trips { get; set; }

        public TripsViewModel()
        {
            LoadTripsFromJson();
        }

        public void AddTrip(Trip trip)
        {
            Trips.Add(trip);
            AppendTripToJson(trip);
        }
        private void LoadTripsFromJson()
        {
            var tripsList = JsonSerializer.Deserialize<List<Trip>>(jsonData);
            Trips = new ObservableCollection<Trip>(tripsList);
        }
        private void AppendTripToJson(Trip trip)
        {
            var tripsList = JsonSerializer.Deserialize<List<Trip>>(jsonData);
            tripsList.Add(trip);
            jsonData = JsonSerializer.Serialize(tripsList);
            // In a real application, you might want to save jsonData to a file or database.
            // For this example, jsonData is simply updated.
        }




    }
}
