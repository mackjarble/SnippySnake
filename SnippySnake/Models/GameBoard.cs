using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippySnake.Models
{
    public class Gameboard
    {
        private int _currentLevel;
        private Snake _snake;
        private Token _token;
        private int _score;

        public int CurrentLevel
        {
            get { return _currentLevel; }
            set { _currentLevel = value; }
        }

        public Snake Snake
        {
            get { return _snake; }
            set { _snake = value; }
        }

        public Token Token
        {
            get { return _token; }
            set { _token = value; }
        }

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public void UpdateGameboardState()
        {
            // code to update the gameboard state based on the current snake and token positions
        }

        public void MoveSnake(Direction direction)
        {
            // code to move the snake in the specified direction
        }

        public bool IsTokenEaten()
        {
            // code to check if the snake has eaten the token
            return false;
        }

        public void AdvanceToNextLevel()
        {
            // code to advance to the next level
        }
    }
}
