using FightingFantasy.Commands;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace FightingFantasy.Models
{
    public class CharacterModel : INotifyPropertyChanged
    {
        private string name = "jsjsdjsiddjio";
        private int luck;
        private int stamina;
        private int skill;

        public string Name
        {
            get => name; 
            set
            {
                name = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }
        public int Luck
        {
            get => luck; 
            set
            {
                luck = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Luck"));
            }
        }
        public int Stamina
        {
            get => stamina; 
            set
            {
                stamina = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Stamina"));
            }
        }
        public int Skill
        {
            get => skill; 
            set
            {
                skill = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Skill"));
            }
        }

        public ICommand GenerateCharacterCommand { get; set; }

        public CharacterModel()
        {
            this.GenerateCharacterCommand = new RelayCommand(() =>
            {
                this.GenerateCharacter();
            });
         }

        public void GenerateCharacter()
        {
            Random random = new Random();
            this.Luck = random.Next(1, 6) + 6;
            this.Skill = random.Next(1, 6) + 6;
            this.Stamina = random.Next(1, 6) + 6;
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
