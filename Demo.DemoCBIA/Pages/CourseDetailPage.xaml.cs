using Demo.DemoCBIA.Models;

namespace Demo.DemoCBIA.Pages;

public partial class CourseDetailPage : ContentPage
{
    public CourseDetailPage(Course course)
    {
        Title = course.Title;

        // Create a grid to display the course details
        Grid detailGrid = new Grid();
        detailGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        detailGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

        // Add labels for each detail
        //detailGrid.Children.Add(new Label { Text = "Course Title: " }, 0, 0);
        //detailGrid.Children.Add(new Label { Text = course.Title }, 1, 0);

        //detailGrid.Children.Add(new Label { Text = "Course Description: " }, 0, 1);
        //detailGrid.Children.Add(new Label { Text = course.Description }, 1, 1);

        // Add more details if needed

        // Set the Content property of the page to the grid
        //Content = detailGrid;
    }
}