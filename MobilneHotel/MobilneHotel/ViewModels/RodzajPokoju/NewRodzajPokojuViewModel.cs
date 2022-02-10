using MobilneHotel.Models;
using MobilneHotel.Services;
using MobilneHotelServiceReference;
using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace MobilneHotel.ViewModels.RodzajPokoju
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class NewRodzajPokojuViewModel : ANewItemViewModel<RodzajPokojuForView>
    {
        public IDataStore<RodzajPokojuForView> DataStore => DependencyService.Get<IDataStore<RodzajPokojuForView>>();//edycja
        private int itemId;//edycja
        private int idRodzajuPokoju;
        private string nazwa;
        private string opis;

        public NewRodzajPokojuViewModel()
            : base()
        {

        }
        public int ItemId//edycja
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }
        public async void LoadItemId(int itemId)//edycja
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                idRodzajuPokoju = item.IdRodzajuPokoju;
                Nazwa = item.Nazwa;
                Opis = item.Opis;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }


        public override bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(nazwa);
        }
        public int IdRodzajuPokoju
        {
            get => idRodzajuPokoju;
            set => SetProperty(ref idRodzajuPokoju, value);
        }
        public string Nazwa
        {
            get => nazwa;
            set => SetProperty(ref nazwa, value);
        }
        public string Opis
        {
            get => opis;
            set => SetProperty(ref opis, value);
        }
        public override RodzajPokojuForView SetItem()
        {
            var newItem = new RodzajPokojuForView()
            {
                IdRodzajuPokoju = IdRodzajuPokoju,
                Nazwa = Nazwa,
                Opis = Opis,
            };
            return newItem;
        }
    }
}
