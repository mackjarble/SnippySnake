using SnippySnake.ViewModels;
using Xamarian.Forms;

namespace SnippySnake.Maui_Views;

public partial class LeaderboardPage : ContentPage
{
	public LeaderboardPage()
	{
		InitializeComponent();
		BindingContext = new LeaderboardViewModel();
	}
}