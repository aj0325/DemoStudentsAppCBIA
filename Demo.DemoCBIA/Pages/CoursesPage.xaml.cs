using Demo.DemoCBIA.Models;


namespace Demo.DemoCBIA.Pages;

public partial class CoursesPage : ContentPage
{
    public List<Course> Courses {  get; set; }

    public CoursesPage()
    {
        InitializeComponent();

        Courses = new List<Course>
        {
            new Course { Title = "Introduction to Programming", Description = "Learn the basics of programming.",StartDate=new DateTime(2024,09,19), EndDate=new DateTime(2025,03,18), KeyDates = "Jan 10, Mar 15" , Events = "Midterm Exam, Final Exam", Agreements =  "Student Handbook,Code of Conduct"  },
            new Course { Title = "Advanced Algorithms", Description = "Explore complex algorithms and data structures.",StartDate=new DateTime(2024,09,03), EndDate=new DateTime(2025,03,25), KeyDates =  "Feb 28, May 10", Events = "Project Due, Final Presentation" , Agreements = "Course Syllabus, Academic Integrity Policy" },
        };

        BindingContext = this;

    }
    
}