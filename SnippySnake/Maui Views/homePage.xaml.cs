using SnippySnake.ViewModels;
using Xamarian.Forms;

namespace SnippySnake.Maui_Views;

public partial class homePage : ContentPage
{
	public homePage()
	{
		InitializeComponent();
		BindingContext = new HomeViewModel();
	}
}