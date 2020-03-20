using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FightingFantasy.Models
{
    /// <summary>
    /// The model for the MainPage.
    /// </summary>
    public class MainPageModel : IMainPageModel, INotifyPropertyChanged
    {
        private bool isStartScreenVisible = true;
        private bool isNewCharacterScreenVisible = false;

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
