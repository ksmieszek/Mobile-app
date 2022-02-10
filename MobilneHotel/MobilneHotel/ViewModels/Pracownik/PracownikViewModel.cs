using MobilneHotel.Services;
using MobilneHotel.Views;
using MobilneHotel.Views.Pracownik;
using MobilneHotelServiceReference;
using System;
using System.Diagnostics;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilneHotel.Models;
namespace MobilneHotel.ViewModels.Pracownik
{
    public class PracownikViewModel : AItemsViewModel<PracownikForView>
    {
        public Command<PracownikForView> ItemTapped { get; }
        public PracownikDataStore pracownikDataStore => DependencyService.Get<PracownikDataStore>();
        public Command<PracownikForView> ItemDelete { get; }
        public Command<KlientForView> IndexRedirect { get; }
        public PracownikViewModel()
           : base("Pracownicy")
        {
            ItemTapped = new Command<PracownikForView>(OnItemSelected);
            ItemDelete = new Command<PracownikForView>(DeleteItem);
            IndexRedirect = new Command<KlientForView>(indexRedirect);

        }
        public void OnItemSelected(PracownikForView item)
        {
            Shell.Current.GoToAsync($"{nameof(NewPracownikPage)}?{nameof(NewPracownikViewModel.ItemId)}={item.IdPracownika}");
        }
        public void DeleteItem(PracownikForView item)
        {
            DataStore.DeleteItemAsync(item.IdPracownika);
        }

        public override void GoToAddPageAsync()
        {
            Shell.Current.GoToAsync(nameof(NewPracownikPage));
        }
        public async void indexRedirect(KlientForView klient)
        {
            await Shell.Current.GoToAsync("//KlientIndexPage");
        }
    }
}
