using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DemoCBIA.ViewModels
{
    public class TaskAreaViewModel : BindableObject
    {
        public ObservableCollection<TaskItem> Tasks { get; } = new ObservableCollection<TaskItem>();

        public TaskAreaViewModel()
        {
            // Populate tasks
            Tasks.Add(new TaskItem { Description = "Attend orientation session", IsCompleted = false });
            Tasks.Add(new TaskItem { Description = "Register for classes", IsCompleted = false });
            Tasks.Add(new TaskItem { Description = "Get student ID card", IsCompleted = false });
            // Add more tasks as needed
        }
    }

    public class TaskItem : BindableObject
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
