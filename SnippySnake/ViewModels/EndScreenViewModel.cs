using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SnippySnake.ViewModels
{
    public class EndScreenViewModel : BaseViewModel
    {
        private int _score;
        public int Score
        {
            get => _score;
            set => SetProperty(ref _score, value);
        }

        private ICommand _restartCommand;
        public ICommand RestartCommand
        {
            get
            {
                return _restartCommand ?? (_restartCommand = new Command(() =>
                {
                    // Code to restart the game
                }));
            }
        }

        private ICommand _homeCommand;
        public ICommand HomeCommand
        {
            get
            {
                return _homeCommand ?? (_homeCommand = new Command(() =>
                {
                    // Code to go back to home screen
                }));
            }
        }
    }
}

