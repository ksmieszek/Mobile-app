using MobilneHotel.Models;
using MobilneHotel.Services;
using MobilneHotelServiceReference;
using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace MobilneHotel.ViewModels.Pracownik
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class NewPracownikViewModel : ANewItemViewModel<PracownikForView>
    {
        public IDataStore<PracownikForView> DataStore => DependencyService.Get<IDataStore<PracownikForView>>();//edycja
        private int itemId;
        private int idPracownika;
        private string imie;
        private string nazwisko;
        private string pesel;
        private string email;
        private string telefon;
        private string miasto;
        private string kodPocztowy;
        private string ulica;
        private string numerDomu;
        private string numerLokalu;
        public NewPracownikViewModel()
            : base()
        {

        }
        public override bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(imie);
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
                idPracownika = item.IdPracownika;
                Imie = item.Imie;
                Nazwisko = item.Nazwisko;
                Email = item.Email;
                Telefon = item.Telefon;
                Pesel = item.Pesel;
                Miasto = item.Miasto;
                KodPocztowy = item.KodPocztowy;
                Ulica = item.Ulica;
                NumerDomu = item.NumerDomu;
                NumerLokalu = item.NumerLokalu;

            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
        public int IdPracownika
        {
            get => idPracownika;
            set => SetProperty(ref idPracownika, value);
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
        public string Pesel
        {
            get => pesel;
            set => SetProperty(ref pesel, value);
        }
        public string Miasto
        {
            get => miasto;
            set => SetProperty(ref miasto, value);
        }
        public string KodPocztowy
        {
            get => kodPocztowy;
            set => SetProperty(ref kodPocztowy, value);
        }
        public string Ulica
        {
            get => ulica;
            set => SetProperty(ref ulica, value);
        }
        public string NumerDomu
        {
            get => numerDomu;
            set => SetProperty(ref numerDomu, value);
        }
        public string NumerLokalu
        {
            get => numerLokalu;
            set => SetProperty(ref numerLokalu, value);
        }
        public override PracownikForView SetItem()
        {
            var newItem = new PracownikForView()
            {
                IdPracownika = IdPracownika,
                Imie = Imie,
                Nazwisko = Nazwisko,
                Email = Email,
                Telefon = Telefon,
                Pesel = Pesel,
                Miasto = Miasto,
                KodPocztowy = KodPocztowy,
                Ulica = Ulica,
                NumerDomu = NumerDomu,
                NumerLokalu = NumerLokalu,
            };
            return newItem;
        }
    }
}
