using SnippySnake.ViewModels;
using Xamarian.Forms;

namespace SnippySnake.Maui_Views;

public partial class GameBoardView : ContentPage
{
	public GameBoardView()
	{
		InitializeComponent();
		BindingContext = new GameViewModel();

        snake.SetBinding(Image.SourceProperty, "SnakeImageSource");
        token.SetBinding(Image.SourceProperty, "TokenImageSource");
        scoreLabel.SetBinding(Label.TextProperty, "ScoreText");
        levelLabel.SetBinding(Label.TextProperty, "LevelText");
    }


    private void OnSizeChanged(object sender, EventArgs e)
    {
        if (BindingContext is GameBoardViewModel vm)
        {
            vm.UpdateGameBoardSize(GameBoardViewName.Width, GameBoardViewName.Height);
        }
    }

}