using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SnippySnake.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        private int _snakeSpeed;
        public int SnakeSpeed
        {
            get { return _snakeSpeed; }
            set { SetProperty(ref _snakeSpeed, value); }
        }

        private bool _isSoundEnabled;
        public bool IsSoundEnabled
        {
            get { return _isSoundEnabled; }
            set { SetProperty(ref _isSoundEnabled, value); }
        }

        private bool _isVibrationEnabled;
        public bool IsVibrationEnabled
        {
            get { return _isVibrationEnabled; }
            set { SetProperty(ref _isVibrationEnabled, value); }
        }

        public ICommand SaveSettingsCommand => new Command(OnSaveSettings);

        public SettingsViewModel()
        {
            // Load settings from storage
            SnakeSpeed = 5;
            IsSoundEnabled = true;
            IsVibrationEnabled = false;
        }

        private void OnSaveSettings()
        {
            // Save settings to storage
            Console.WriteLine($"Snake speed: {SnakeSpeed}");
            Console.WriteLine($"Sound enabled: {IsSoundEnabled}");
            Console.WriteLine($"Vibration enabled: {IsVibrationEnabled}");
        }
    }
}
