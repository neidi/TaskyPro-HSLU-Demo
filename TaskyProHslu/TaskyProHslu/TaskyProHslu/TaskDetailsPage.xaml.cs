using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskyProHslu
{

    
    public partial class TaskDetailsPage : ContentPage
    {
        private readonly ObservableCollection<Task> taskList;

        public TaskDetailsPage(ObservableCollection<Task> taskList)
        {
            this.taskList = taskList;
            this.InitializeComponent();
            this.CurrentTask = new Task();
            this.BindingContext = this.CurrentTask;
        }

        public TaskDetailsPage(Task task, ObservableCollection<Task> taskList)
        {
            this.taskList = taskList;
            this.InitializeComponent();
            this.CurrentTask = task;
            this.BindingContext = this.CurrentTask;
        }

        public Task CurrentTask { get; set; }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            if (!this.taskList.Contains(this.CurrentTask))
            {
                this.taskList.Add(this.CurrentTask);
            }
            this.Navigation.PopAsync(true);
        }
    }
    
}
