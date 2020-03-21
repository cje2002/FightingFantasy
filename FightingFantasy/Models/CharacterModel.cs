using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FightingFantasy.Models
{
    public class CharacterModel : ICharacterModel
    {
        private string name;
        private int luck;
        private int stamina;
        private int skill;

        public CharacterModel()
        {
            this.GenerateCharacter();
        }

        public string Name
        {
            get => name;
            set
            {
                name = value;
                this.OnPropertyChanged("Name");
            }
        }
        public int Luck
        {
            get => luck;
            set
            {
                luck = value;
                this.OnPropertyChanged("Luck");
            }
        }
        public int Stamina
        {
            get => stamina;
            set
            {
                stamina = value;
                this.OnPropertyChanged("Stamina");
            }
        }
        public int Skill
        {
            get => skill;
            set
            {
                skill = value;
                this.OnPropertyChanged("Skill");
            }
        }

        public void GenerateCharacter()
        {
            Random random = new Random();
            this.Luck = random.Next(1, 7) + 6;
            this.Skill = random.Next(1, 7) + 6;
            this.Stamina = random.Next(1, 7) + 12;
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
