using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SnippySnake.ViewModels
{
    public class LevelTransitionViewModel : BaseViewModel
    {
        private int _currentLevel;
        public int CurrentLevel
        {
            get { return _currentLevel; }
            set { SetProperty(ref _currentLevel, value); }
        }

        private int _score;
        public int Score
        {
            get { return _score; }
            set { SetProperty(ref _score, value); }
        }

        public LevelTransitionViewModel(int currentLevel, int score)
        {
            CurrentLevel = currentLevel;
            Score = score;
            GoToNextLevelCommand = new Command(async () => await GoToNextLevel());
        }

        public Command GoToNextLevelCommand { get; }

        private async Task GoToNextLevel()
        {
            // Logic for transitioning to the next level
            await Application.Current.MainPage.Navigation.PushAsync(new GamePage(CurrentLevel + 1));
        }
    }
}

