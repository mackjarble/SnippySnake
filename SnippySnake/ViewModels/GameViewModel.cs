using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using SnippySnake.Models;

namespace SnippySnake.ViewModels
{
    public class GameViewModel : BaseViewModel
    {
        private SnakeModel _snake;
        private TokenModel _token;
        private GameboardModel _gameboard;

        public GameViewModel()
        {
            _snake = new SnakeModel();
            _token = new TokenModel();
            _gameboard = new GameboardModel();
        }

        public ICommand MoveCommand => new Command<string>((direction) =>
        {
            if (direction == "up")
            {
                _snake.MoveUp();
            }
            else if (direction == "down")
            {
                _snake.MoveDown();
            }
            else if (direction == "left")
            {
                _snake.MoveLeft();
            }
            else if (direction == "right")
            {
                _snake.MoveRight();
            }

            // check for collision with token
            if (_gameboard.CheckForCollision(_snake.HeadPosition, _token.Position))
            {
                _snake.Grow();
                _token.GenerateNewPosition();
            }

            // check for collision with walls or snake body
            if (_gameboard.CheckForCollision(_snake.HeadPosition))
            {
                // game over
                // navigate to game over screen
            }
        });

        public SnakeModel Snake
        {
            get { return _snake; }
            set { SetProperty(ref _snake, value); }
        }

        public TokenModel Token
        {
            get { return _token; }
            set { SetProperty(ref _token, value); }
        }

        public GameboardModel Gameboard
        {
            get { return _gameboard; }
            set { SetProperty(ref _gameboard, value); }
        }
    }
}
