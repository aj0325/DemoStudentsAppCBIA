using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace Demo.DemoCBIA.ViewModels
{
    public class NotificationsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Notification> _notifications;
        public ObservableCollection<Notification> Notifications
        {
            get { return _notifications; }
            set
            {
                _notifications = value;
                OnPropertyChanged(nameof(Notifications));
            }
        }

        private bool _isEditMode = false;
        public bool IsEditMode
        {
            get { return _isEditMode; }
            set
            {
                _isEditMode = value;
                OnPropertyChanged(nameof(IsEditMode));
            }
        }

        public NotificationsViewModel()
        {
            Notifications = new ObservableCollection<Notification>();
            // Populate notifications (replace with your actual data)
            Notifications.Add(new Notification { Title = "Notification 1", Content = "Content 1", Date = DateTime.Now });
            Notifications.Add(new Notification { Title = "Notification 2", Content = "Content 2", Date = DateTime.Now.AddMinutes(-30) });
            Notifications.Add(new Notification { Title = "Notification 3", Content = "Content 3", Date = DateTime.Now.AddHours(-2) });
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Notification : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
