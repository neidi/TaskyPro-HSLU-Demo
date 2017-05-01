using System.ComponentModel;
using System.Runtime.CompilerServices;
using TaskyProHslu.Annotations;

namespace TaskyProHslu
{
    public class Task : INotifyPropertyChanged
    {
        private string name;
        private string description;
        private bool isCompleted;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.name == value)
                {
                    return;
                }
                this.name = value;
                this.RaisePropertyChanged();
            }
        }

        public string Description
        {
            get { return this.description; }
            set
            {
                if (this.description == value)
                {
                    return;
                }
                this.description = value;
                this.RaisePropertyChanged();
            }
        }

        public bool IsCompleted
        {
            get { return this.isCompleted; }
            set {
                if (this.isCompleted == value)
                {
                    return;
                }
                this.isCompleted = value;
                this.RaisePropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}