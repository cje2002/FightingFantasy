using System.ComponentModel;

namespace FightingFantasy.Models
{
    public interface ICharacterModel: INotifyPropertyChanged
    {
        int Luck { get; set; }
        string Name { get; set; }
        int Skill { get; set; }
        int Stamina { get; set; }

        void GenerateCharacter();
    }
}