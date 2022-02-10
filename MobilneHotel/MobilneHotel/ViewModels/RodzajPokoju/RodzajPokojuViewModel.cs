using MobilneHotel.Services;
using MobilneHotel.Views;
using MobilneHotel.Views.RodzajPokoju;
using MobilneHotelServiceReference;
using System;
using System.Diagnostics;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilneHotel.Models;

namespace MobilneHotel.ViewModels.RodzajPokoju
{
    public class RodzajPokojuViewModel : AItemsViewModel<RodzajPokojuForView>
    {
        public Command<RodzajPokojuForView> ItemTapped { get; }
        public RodzajPokojuDataStore rodzajPokojuDataStore => DependencyService.Get<RodzajPokojuDataStore>();
        public Command<RodzajPokojuForView> ItemDelete { get; }
        public Command<RodzajPokojuForView> IndexRedirect { get; }
        public RodzajPokojuViewModel()
           : base("Rodzaje pokojow")
        {
            ItemTapped = new Command<RodzajPokojuForView>(OnItemSelected);
            ItemDelete = new Command<RodzajPokojuForView>(DeleteItem);
            IndexRedirect = new Command<RodzajPokojuForView>(indexRedirect);
        }
        public void OnItemSelected(RodzajPokojuForView item)
        {
            Shell.Current.GoToAsync($"{nameof(NewRodzajPokojuPage)}?{nameof(NewRodzajPokojuViewModel.ItemId)}={item.IdRodzajuPokoju}");
        }
        public void DeleteItem(RodzajPokojuForView item)
        {
            DataStore.DeleteItemAsync(item.IdRodzajuPokoju);
        }
        public override void GoToAddPageAsync()
        {
            Shell.Current.GoToAsync(nameof(NewRodzajPokojuPage));
        }
        public async void indexRedirect(RodzajPokojuForView rodzajPokoju)
        {
            await Shell.Current.GoToAsync("//RodzajPokojuIndexPage");
        }
    }
}
