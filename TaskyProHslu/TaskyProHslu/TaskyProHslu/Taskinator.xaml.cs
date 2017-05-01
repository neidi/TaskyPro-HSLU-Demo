using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace TaskyProHslu
{
    public partial class Taskinator
    {
        public Taskinator()
        {
            this.InitializeComponent();
            this.TaskList = new ObservableCollection<Task>
            {
                new Task
                {
                    Name = "Teach at HSLU",
                    Description = "Let those students learn something",
                    IsCompleted = false
                }
            };
            this.BindingContext = this;
        }

        public ObservableCollection<Task> TaskList { get; set; }

        private void OnAddItemClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new TaskDetailsPage(this.TaskList));
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            Task selectedTask = (Task) e.SelectedItem;
            this.Navigation.PushAsync(new TaskDetailsPage(selectedTask, this.TaskList));
            this.MyListView.SelectedItem = null;
        }
    }
}