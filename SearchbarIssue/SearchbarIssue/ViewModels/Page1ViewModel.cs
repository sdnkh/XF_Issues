using System.ComponentModel;
using System.Threading.Tasks;

namespace SearchbarIssue.ViewModels
{
    public class Page1ViewModel : INotifyPropertyChanged
    {
        public const string IsLoadedPropertyName = "IsLoaded";
        public event PropertyChangedEventHandler PropertyChanged;

        private bool isLoaded;

        public bool IsLoaded
        {
            get
            {
                return this.isLoaded;
            }

            set
            {
                this.isLoaded = value;
                if (this.PropertyChanged == null)
                {
                    return;
                }

                this.PropertyChanged(this, new PropertyChangedEventArgs(IsLoadedPropertyName));
            }
        }

        public async Task LoadData()
        {
            this.IsLoaded = false;
            await Task.Delay(2000);
            this.IsLoaded = true;
        }
    }
}
