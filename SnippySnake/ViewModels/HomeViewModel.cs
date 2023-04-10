using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SnippySnake.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ICommand NavigateToGameCommand { get; private set; }
        public ICommand NavigateToLeaderboardCommand { get; private set; }
        public ICommand NavigateToSettingsCommand { get; private set; }
        public ICommand NavigateToStoreCommand { get; private set; }

        public HomeViewModel()
        {
            NavigateToGameCommand = new Command(() => NavigateTo("Game"));
            NavigateToLeaderboardCommand = new Command(() => NavigateTo("Leaderboard"));
            NavigateToSettingsCommand = new Command(() => NavigateTo("Settings"));
            NavigateToStoreCommand = new Command(() => NavigateTo("Store"));
        }

        private async void NavigateTo(string pageName)
        {
            await Shell.Current.GoToAsync($"//{pageName}");
        }
    }
}

