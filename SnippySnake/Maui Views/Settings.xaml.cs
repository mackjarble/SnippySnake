using Xamarian.Forms;

namespace SnippySnake.Maui_Views;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
        BindingContext = new SettingsViewModel();
    }
}