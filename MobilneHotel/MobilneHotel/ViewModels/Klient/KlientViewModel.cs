using MobilneHotel.Services;
using MobilneHotel.Views;
using MobilneHotel.Views.Klient;
using MobilneHotelServiceReference;
using System;
using System.Diagnostics;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilneHotel.Models;

namespace MobilneHotel.ViewModels.Klient
{

    public class KlientViewModel : AItemsViewModel<KlientForView>
    {
        public Command<KlientForView> ItemTapped { get; }
        public KlientDataStore klientDataStore => DependencyService.Get<KlientDataStore>();
        public Command<KlientForView> ItemDelete { get; }
        public Command<KlientForView> IndexRedirect { get; }
       
        public KlientViewModel()
           : base("Klienci")
        {
            ItemTapped = new Command<KlientForView>(OnItemSelected);
            ItemDelete = new Command<KlientForView>(DeleteItem);
            IndexRedirect = new Command<KlientForView>(indexRedirect);
        }
        public void OnItemSelected(KlientForView item)
        {
            Shell.Current.GoToAsync($"{nameof(NewKlientPage)}?{nameof(NewKlientViewModel.ItemId)}={item.IdKlienta}");
        }
        public void DeleteItem(KlientForView item)
        {
            DataStore.DeleteItemAsync(item.IdKlienta);
        }
        public override void GoToAddPageAsync()
        {
            Shell.Current.GoToAsync(nameof(NewKlientPage));
        }
        public async void indexRedirect(KlientForView klient)
        {
            await Shell.Current.GoToAsync("//KlientIndexPage");
        }
    }

}
