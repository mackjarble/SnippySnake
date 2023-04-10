using SnippySnake.ViewModels;
using Xamarian.Forms;

namespace SnippySnake.Maui_Views;

public partial class GameOverPage : ContentPage
{
	public GameOverPage()
	{
		InitializeComponent();
		BindingContext = new EndScreenViewModel();
	}
}