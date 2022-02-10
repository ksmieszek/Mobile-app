using MobilneHotel.Models;
using MobilneHotel.Services;
using MobilneHotelServiceReference;
using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace MobilneHotel.ViewModels.Klient
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class NewKlientViewModel : ANewItemViewModel<KlientForView>
    {
        public IDataStore<KlientForView> DataStore => DependencyService.Get<IDataStore<KlientForView>>();//edycja
        private int itemId;//edycja
        private int idKlienta;
        private string imie;
        private string nazwisko;
        private string email;
        private string telefon;
        public NewKlientViewModel()
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
                idKlienta = item.IdKlienta;
                Imie = item.Imie;
                Nazwisko = item.Nazwisko;
                Email = item.Email;
                Telefon = item.Telefon;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }


        public override bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(imie);
        }
        public int IdKlienta
        {
            get => idKlienta;
            set => SetProperty(ref idKlienta, value);
        }
        public string Imie
        {
            get => imie;
            set => SetProperty(ref imie, value);
        }
        public string Nazwisko
        {
            get => nazwisko;
            set => SetProperty(ref nazwisko, value);
        }
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }
        public string Telefon
        {
            get => telefon;
            set => SetProperty(ref telefon, value);
        }
        public override KlientForView SetItem()
        {
            var newItem = new KlientForView()
            {
                IdKlienta = IdKlienta,
                Imie = Imie,
                Nazwisko = Nazwisko,
                Email = Email,
                Telefon = Telefon,
            };
            return newItem;
        }
    }
}
