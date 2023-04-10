using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnippySnake.Models;
using System.Collections.ObjectModel;

namespace SnippySnake.ViewModels
{
    public class LeaderboardViewModel : BaseViewModel
    {
        public ObservableCollection<Score> Scores { get; set; }

        public LeaderboardViewModel()
        {
            Scores = new ObservableCollection<Score>();

            // Load scores from database or API
            LoadScores();
        }

        private void LoadScores()
        {
            // Example data
            Scores.Add(new Score { Name = "John", Value = 100 });
            Scores.Add(new Score { Name = "Jane", Value = 75 });
            Scores.Add(new Score { Name = "Bob", Value = 50 });
            Scores.Add(new Score { Name = "Alice", Value = 25 });
        }
    }
}
