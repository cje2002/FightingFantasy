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

        private readonly IMainPageModel mainPageModel ;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand GenerateCharacterCommand { get; set; }

        public ICommand BackCommand { get; set; }

        public ICommand StartCommand { get; set; }

        public ICharacterModel CharacterModel => characterModel;

        public CharacterViewModel()
        {

            this.characterModel = WindsorContainerFactory.Container.Resolve<ICharacterModel>();
            this.characterModel.PropertyChanged += CharacterModel_PropertyChanged;

            this.mainPageModel = WindsorContainerFactory.Container.Resolve<IMainPageModel>();

            GenerateCharacterCommand = new RelayCommand(() =>
            {
                characterModel.GenerateCharacter();
            });

            BackCommand = new RelayCommand(() =>
            {
                mainPageModel.ShowStartScreen();
            });
        }

        private void CharacterModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(e.PropertyName));
        }
    }
}
