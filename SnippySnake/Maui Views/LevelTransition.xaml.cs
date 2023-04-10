using SnippySnake.ViewModels;
using Xamarian.Forms;

namespace SnippySnake.Maui_Views;

public partial class LevelTransition : ContentPage
{
	public LevelTransition()
	{
		InitializeComponent();
		BindingContext = new LevelTransitionViewModel();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is LevelTransitionViewModel vm)
        {
            vm.SetSelectedLevel(LevelSelected);
        }
    }

}