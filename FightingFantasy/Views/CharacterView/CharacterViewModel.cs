using FightingFantasy.Commands;
using FightingFantasy.IoC;
using FightingFantasy.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace FightingFantasy.Views.CharacterView
{
    public class CharacterViewModel : INotifyPropertyChanged
    {
        private readonly ICharacterModel characterModel;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand GenerateCharacterCommand { get; set; }

        public ICharacterModel CharacterModel => characterModel;

        public CharacterViewModel()
        {

            this.characterModel = WindsorContainerFactory.Container.Resolve<ICharacterModel>();
            this.characterModel.PropertyChanged += CharacterModel_PropertyChanged;

            GenerateCharacterCommand = new RelayCommand(() =>
            {
                characterModel.GenerateCharacter();
            });
        }

        private void CharacterModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(e.PropertyName));
        }
    }
}
