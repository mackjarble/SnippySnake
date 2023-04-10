using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using SnippySnake.Models;
using SnippySnake.Services;
using Xamarin.Forms;

namespace SnippySnake.ViewModels
{
    public class StoreViewModel : BaseViewModel
    {
        private readonly IStoreService _storeService;
        private readonly ObservableCollection<StoreItem> _storeItems = new ObservableCollection<StoreItem>();

        public StoreViewModel(IStoreService storeService)
        {
            _storeService = storeService;
            LoadStoreItems();
        }

        public ObservableCollection<StoreItem> StoreItems => _storeItems;

        public ICommand BuyCommand => new Command<StoreItem>(OnBuyCommandExecuted);

        private async void LoadStoreItems()
        {
            var storeItems = await _storeService.GetStoreItemsAsync();
            foreach (var item in storeItems)
            {
                _storeItems.Add(item);
            }
        }

        private void OnBuyCommandExecuted(StoreItem storeItem)
        {
            // TODO: Implement logic for buying item
        }
    }
}
