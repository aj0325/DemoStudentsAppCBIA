using Plugin.Maui.Calendar.Models;

namespace Demo.DemoCBIA.Pages;

public partial class KeyDatesPage : ContentPage
{
    public EventCollection Events { get; set; }
    public KeyDatesPage()
	{
		InitializeComponent();
        Events = new EventCollection
        {
            [DateTime.Now] = new List<EventModel>
            {
                    new EventModel { Name = "Orientation Day", Description = "Welcome new students to campus!" },
                    new EventModel { Name = "Club Fair", Description = "Explore various student clubs and organizations." }
                },
            // 5 days from today
            [DateTime.Now.AddDays(5)] = new List<EventModel>
            {
                    new EventModel { Name = "Field Trip to Museum", Description = "Visit the local museum for an educational tour." },
                    new EventModel { Name = "Career Workshop", Description = "Learn about career opportunities and resume building." }
                },
            
            // custom date
            [new DateTime(2024, 4, 26)] = new List<EventModel>
            {
                    new EventModel { Name = "Startup Pitch Competition", Description = "Present your business ideas in front of a panel of judges." }
                },
            [new DateTime(2024, 4, 30)] = new List<EventModel>
            {
                    new EventModel { Name = "Leadership Seminar", Description = "Enhance your leadership skills with industry experts." },
                    new EventModel { Name = "Networking Mixer", Description = "Connect with alumni and industry professionals." }
                },
            [new DateTime(2024, 5, 12)] = new List<EventModel>
            {
                    new EventModel { Name = "Business Ethics Workshop", Description = "Discuss ethical dilemmas in business." },
                },
            [new DateTime(2024, 5, 20)] = new List<EventModel>
            {
                    new EventModel { Name = "Trip", Description = "Trip details" },
                },

        };

        BindingContext = this;
    }

    internal class EventModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}