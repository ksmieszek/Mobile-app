using MobilneHotel.Services;
using MobilneHotel.Views.Rezerwacja;
using MobilneHotelServiceReference;
using Xamarin.Forms;

namespace MobilneHotel.ViewModels.Rezerwacja
{
    public class RezerwacjaViewModel : AItemsViewModel<RezerwacjaForView>
    {
        public Command<RezerwacjaForView> ItemTapped { get; }
        public RezerwacjaDataStore rezerwacjaDataStore => DependencyService.Get<RezerwacjaDataStore>();
        public Command<RezerwacjaForView> ItemDelete { get; }
        public Command IndexRedirect { get; }
        public RezerwacjaViewModel()
           : base("Rezerwacje")
        {
            ItemTapped = new Command<RezerwacjaForView>(OnItemSelected);
            ItemDelete = new Command<RezerwacjaForView>(DeleteItem);
            IndexRedirect = new Command(indexRedirect);
        }
        public void OnItemSelected(RezerwacjaForView item)//edycja
        {
            Shell.Current.GoToAsync($"{nameof(NewRezerwacjaPage)}?{nameof(NewRezerwacjaViewModel.ItemId)}={item.IdRezerwacji}");
        }
        public void DeleteItem(RezerwacjaForView item)
        {
            DataStore.DeleteItemAsync(item.IdRezerwacji);
        }
        public override void GoToAddPageAsync()
        {
            Shell.Current.GoToAsync(nameof(NewRezerwacjaPage));
        }
        public async void indexRedirect()
        {
            await Shell.Current.GoToAsync("//RezerwacjaIndexPage");
        }
    }
}
