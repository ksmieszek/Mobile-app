using MobilneHotel.Services;
using MobilneHotel.Views.Pokoj;
using MobilneHotelServiceReference;
using Xamarin.Forms;


namespace MobilneHotel.ViewModels.Pokoj
{
   public  class PokojViewModel : AItemsViewModel<PokojForView>
    {
        public Command<PokojForView> ItemTapped { get; }
        public PokojDataStore pokojDataStore => DependencyService.Get<PokojDataStore>();
        public Command<PokojForView> ItemDelete { get; }
        public Command IndexRedirect { get; }
        public PokojViewModel()
          : base("Pokoje")
        {
            ItemTapped = new Command<PokojForView>(OnItemSelected);
            ItemTapped = new Command<PokojForView>(OnItemSelected);
            ItemDelete = new Command<PokojForView>(DeleteItem);
            IndexRedirect = new Command(indexRedirect);
        }
        public void OnItemSelected(PokojForView item)//edycja
        {
            Shell.Current.GoToAsync($"{nameof(NewPokojPage)}?{nameof(NewPokojViewModel.ItemId)}={item.IdPokoju}");
        }
        public void DeleteItem(PokojForView item)
        {
            DataStore.DeleteItemAsync(item.IdPokoju);
        }
        public override void GoToAddPageAsync()
        {
            Shell.Current.GoToAsync(nameof(NewPokojPage));
        }
        public async void indexRedirect()
        {
            await Shell.Current.GoToAsync("//PokojIndexPage");
        }
    }
}
