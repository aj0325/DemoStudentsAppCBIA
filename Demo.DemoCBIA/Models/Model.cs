using DevExpress.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DemoCBIA.Models
{
    public class Resources
    {
        public ObservableCollection<Restaurant> Restaurants { get; set; }
        public ObservableCollection<Hospital> Hospitals { get; set; }
    
        public Resources()
        {
            Restaurants = new ObservableCollection<Restaurant>();
            Hospitals = new ObservableCollection<Hospital>();
        }
    }
    
    public class Restaurant
    {
        public string Name { get; set; }
        public Location Location { get; set; }
        // Add other properties specific to a restaurant
    }
    
    public class Hospital
    {
        public string Name { get; set; }
        public Location Location { get; set; }
        // Add other properties specific to a hospital
    }
    public class AccommodationDetails
    {
        // Properties
        public string RoomNumber { get; set; }
        public string BuildingName { get; set; }
        public string Floor { get; set; }
        public bool IsSingleOccupancy { get; set; }
        public int NumberOfRoommates { get; set; }
        public List<string> RoommateNames { get; set; }

        // Constructor
        public AccommodationDetails()
        {
            RoommateNames = new List<string>();
        }

        // Method to add a roommate name to the list
        
    }

    public class Question
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string QuestionText { get; set; }
        public string Status { get; set; } // "Pending" or "Solved"
        public List<string> Answers { get; set; } = new List<string>();
        // You can add properties for images or files as needed
    }
    public class Trip
    {
        public string Name { get; set; } 
        public string Location { get; set; }
        public bool GoingFormFilled { get; set; }
        public string FullName { get; set; }
        public string StudentId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Purpose { get; set; }
    }


    public class CulturalEvent
    {
        public string EventName { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool SignedUp { get; set; }
    }

    public class Course
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string KeyDates { get; set; }
        public string Events { get; set; }
        public string Agreements { get; set; }
    }

    public class PdfModel
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }

    public class TripInformation
    {
        public string FullName { get; set; }
        public string StudentId { get; set; }
        public string PhoneNumber { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Purpose { get; set; }
        // Add other properties as needed (e.g., transportation, lodging, medical info)
    }
    public class ProfileInfo
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string DietaryPreference { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyPhoneNumber { get; set; }
        public string EmergencyContactRelationship { get; set; }
        public string ImageSource { get; set; }
        public List<string> GenderOptions { get; } = new List<string> { "Female", "Male", "Other" };
        public List<string> DietaryOptions { get; } = new List<string> { "Vegetarian", "Non-Vegetarian", "Vegan" };
    }

    

    public class ProfileModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string DietaryPreference { get; set; }
        public string ImageSource { get; set; }
    }
}
