using Demo.DemoCBIA.ViewModels;
using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace Demo.DemoCBIA.Pages
{
    public partial class NotificationsPage : ContentPage
    {
        public NotificationsPage()
        {
            InitializeComponent();
            BindingContext = new NotificationsViewModel();
            if (BindingContext is NotificationsViewModel viewModel)
            {
                viewModel.IsEditMode = false;
            }
        }

        private void SelectButton_Clicked(object sender, EventArgs e)
        {
            // Toggle IsEditMode when the "Select" button is clicked
            if (BindingContext is NotificationsViewModel viewModel)
            {
                viewModel.IsEditMode = !viewModel.IsEditMode;
            }
        }

        private void ToggleEditMode_Clicked(object sender, EventArgs e)
        {
            var viewModel = BindingContext as NotificationsViewModel;
            if (viewModel != null)
            {
                viewModel.IsEditMode = !viewModel.IsEditMode;
                // Clear selected items when exiting edit mode
                if (!viewModel.IsEditMode)
                {
                    foreach (var notification in viewModel.Notifications)
                    {
                        notification.IsSelected = false;
                    }
                }
            }
        }

        private void NotificationsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var viewModel = BindingContext as NotificationsViewModel;
            if (viewModel != null)
            {
                if (viewModel.IsEditMode)
                {
                    // Deselect items that were previously selected but are now deselected
                    foreach (var notification in e.PreviousSelection)
                    {
                        ((Notification)notification).IsSelected = false;
                    }
                    // Select items that are currently selected
                    foreach (var notification in e.CurrentSelection)
                    {
                        ((Notification)notification).IsSelected = true;
                    }
                }
            }
        }

        private void DeleteSelected_Clicked(object sender, EventArgs e)
        {
            var viewModel = BindingContext as NotificationsViewModel;
            if (viewModel != null)
            {
                var selectedItems = viewModel.Notifications.Where(n => n.IsSelected).ToList();
                foreach (var notification in selectedItems)
                {
                    viewModel.Notifications.Remove(notification);
                }
            }
        }


    }
}
