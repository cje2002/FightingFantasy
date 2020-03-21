namespace FightingFantasy.Models
{
    public interface IMainPageModel
    {
        bool IsNewCharacterScreenVisible { get; set; }
        bool IsStartScreenVisible { get; set; }

        void ShowNewCharacterScreen();

        void ShowStartScreen();
    }
}