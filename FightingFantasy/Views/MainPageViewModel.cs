using FightingFantasy.Commands;
using FightingFantasy.IoC;
using FightingFantasy.Models;
using System.Windows.Input;
using Windows.UI.Xaml;

namespace FightingFantasy.Views
{
    public class MainPageViewModel
    {
        private readonly IMainPageModel mainPageModel;

        public IMainPageModel MainPageModel => mainPageModel;
              
        public ICommand StartCommand { get; set; }

        public ICommand QuitCommand { get; set; }

        public MainPageViewModel()
        {
            this.mainPageModel = WindsorContainerFactory.Container.Resolve<IMainPageModel>();

            StartCommand = new RelayCommand(() =>
            {
                mainPageModel.ShowNewCharacterScreen();
            });

            QuitCommand = new RelayCommand(() =>
            {
                Application.Current.Exit();
            });
        }
    }
}
