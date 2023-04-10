using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippySnake.Models
{
    public class Scoreboard
    {
        private int _score;

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        private int _level;

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        // Constructor to initialize the scoreboard
        public Scoreboard()
        {
            Score = 0;
            Level = 1;
        }

        // Method to update the scoreboard based on the snake's actions
        public void UpdateScoreboard(int pointsToAdd)
        {
            Score += pointsToAdd;
            // Check if the snake has reached the next level
            if (Score % 10 == 0)
            {
                Level++;
            }
        }
    }
}
