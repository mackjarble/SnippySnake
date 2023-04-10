using SnippySnake.ViewModels;
using Xamarian.Forms;

namespace SnippySnake.Maui_Views;

public partial class Shop : ContentPage
{
	public Shop()
	{
		InitializeComponent();
        BindingContext = new StoreViewModel();
	}
    private void OnBuyButtonClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.BindingContext is StoreItemViewModel item)
        {
            if (BindingContext is StoreViewModel vm)
            {
                vm.BuyItem(item);
            }
        }
    }
}