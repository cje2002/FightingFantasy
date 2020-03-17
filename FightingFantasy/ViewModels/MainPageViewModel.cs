using FightingFantasy.Commands;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Windows.UI.Xaml;

namespace FightingFantasy.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private bool isStartScreenVisible = true;
        private bool isNewCharacterScreenVisible = false;

        public ICommand StartCommand { get; set; }

        public ICommand QuitCommand { get; set; }

        public MainPageViewModel()
        {
            StartCommand = new RelayCommand(() =>
            {
                IsStartScreenVisible = false;
                IsNewCharacterScreenVisible = true;
            });
            QuitCommand = new RelayCommand(() =>
            {
                //TODO
                Application.Current.Exit();
            });
        }

        /// <summary>
        /// Is the start screen visible?
        /// </summary>
        public bool IsStartScreenVisible
        {
            get => isStartScreenVisible; 
            set
            {
                isStartScreenVisible = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("IsStartScreenVisible"));
            }
        }

        /// <summary>
        /// Is the new character screen screen visible?
        /// </summary>
        public bool IsNewCharacterScreenVisible
        {
            get => isNewCharacterScreenVisible; 
            set
            {
                isNewCharacterScreenVisible = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("IsNewCharacterScreenVisible"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
