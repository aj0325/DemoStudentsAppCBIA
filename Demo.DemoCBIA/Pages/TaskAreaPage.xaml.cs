using Demo.DemoCBIA.ViewModels;
namespace Demo.DemoCBIA.Pages;

public partial class TaskAreaPage : ContentPage
{
    public TaskAreaPage()
    {
        InitializeComponent();
        BindingContext = new TaskAreaViewModel();
        PopulateTaskList();
    }

    private void PopulateTaskList()
    {
        var viewModel = BindingContext as TaskAreaViewModel;
        if (viewModel != null)
        {
            foreach (var task in viewModel.Tasks)
            {
                var checkbox = new CheckBox
                {
                    IsChecked = task.IsCompleted
                };
                checkbox.CheckedChanged += (sender, e) =>
                {
                    task.IsCompleted = e.Value;
                    // Optionally, you can implement logic here to save task completion state
                };

                var label = new Label
                {
                    Text = task.Description,
                    VerticalOptions = LayoutOptions.Center
                };

                var stackLayout = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Children = { checkbox, label }
                };

                taskList.Children.Add(stackLayout);
            }
        }
    }
}