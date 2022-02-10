using MobilneHotel.Services;
using MobilneHotelServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using MobilneHotel.Models;
using System.Linq;

namespace MobilneHotel.ViewModels.Rezerwacja
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class NewRezerwacjaViewModel : ANewItemViewModel<RezerwacjaForView>
    {
        public IDataStore<RezerwacjaForView> DataStore => DependencyService.Get<IDataStore<RezerwacjaForView>>();//edycja
        private KlientForView selectedKlient;
        private PracownikForView selectedPracownik;
        private PokojForView selectedPokoj;
        private int itemId;//edycja
        private decimal razem;
        private int idRezerwacji;
        private DateTime dataRozpoczecia;
        private DateTime dataZakonczenia;


        public NewRezerwacjaViewModel()
           : base()
        {
            selectedKlient = new KlientForView();
            selectedPracownik = new PracownikForView();
            selectedPokoj = new PokojForView();
            DataRozpoczecia = DateTime.Now;
            DataZakonczenia = DateTime.Now.AddDays(1);

        }
        public List<KlientForView> Klienci
        {
            get
            {
                var klientStore = DependencyService.Get<ItemDataStore<KlientForView>>();
                return klientStore.items;
            }
        }

        public List<PracownikForView> Pracownicy
        {
            get
            {
                var pracownikStore = DependencyService.Get<ItemDataStore<PracownikForView>>();
                return pracownikStore.items;
            }
        }
        public List<PokojForView> Pokoje
        {
            get
            {
                var pokojStore = DependencyService.Get<ItemDataStore<PokojForView>>();
                return pokojStore.items;
            }
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
            var item = await DataStore.GetItemAsync(itemId);
            idRezerwacji = item.IdRezerwacji;
            Razem = (decimal)item.Razem;
            DataRozpoczecia = (DateTime)item.DataRozpoczecia;
            DataZakonczenia = (DateTime)item.DataZakonczenia;
            var KlientIndexInList = Klienci.FindIndex(x => x.IdKlienta == item.IdKlienta);
            SelectedKlient = Klienci[KlientIndexInList];
            var PracownikIndexInList = Pracownicy.FindIndex(x => x.IdPracownika == item.IdPracownika);
            SelectedPracownik = Pracownicy[PracownikIndexInList];
            var PokojIndexInList = Pokoje.FindIndex(x => x.IdPokoju == item.IdPokoju);
            SelectedPokoj = Pokoje[PokojIndexInList];
        }
        public override bool ValidateSave()
        {
            return !string.IsNullOrWhiteSpace(selectedKlient.Imie) && !string.IsNullOrWhiteSpace(selectedPracownik.Imie);
        }

        public KlientForView SelectedKlient
        {
            get => selectedKlient;
            set => SetProperty(ref selectedKlient, value);
        }
        public PracownikForView SelectedPracownik
        {
            get => selectedPracownik;
            set => SetProperty(ref selectedPracownik, value);
        }
        public PokojForView SelectedPokoj
        {
            get => selectedPokoj;
            set => SetProperty(ref selectedPokoj, value);
        }
        public int IdRezerwacji
        {
            get => idRezerwacji;
            set => SetProperty(ref idRezerwacji, value);
        }

        public decimal Razem
        {
            get => razem;
            set => SetProperty(ref razem, value);
        }
        public DateTime DataRozpoczecia
        {
            get => dataRozpoczecia;
            set => SetProperty(ref dataRozpoczecia, value);
        }
        public DateTime DataZakonczenia
        {
            get => dataZakonczenia;
            set => SetProperty(ref dataZakonczenia, value);
        }

        public decimal? UtargPokoj()
        {
            var dataOd = dataRozpoczecia;
            var dataDo = dataZakonczenia;
            var cenaPokoju = selectedPokoj.Cena;
            int liczbaDni = (dataDo.Date - dataOd.Date).Days;
            return cenaPokoju * liczbaDni;
        }
        public override RezerwacjaForView SetItem()
        {
            var utargZaPokoj = UtargPokoj();

            var newItem = new RezerwacjaForView()
            {
                IdRezerwacji = IdRezerwacji,
                Razem = utargZaPokoj,
                IdKlienta = SelectedKlient.IdKlienta,
                IdPracownika = SelectedPracownik.IdPracownika,
                IdPokoju = SelectedPokoj.IdPokoju,
                KlientDane = $"{selectedKlient.Imie} {selectedKlient.Nazwisko}",
                PracownikDane = $"{selectedPracownik.Imie} {SelectedPracownik.Nazwisko}",
                PokojDane = $"{selectedPokoj.Nazwa}",
                DataRozpoczecia =DataRozpoczecia,
                DataZakonczenia=DataZakonczenia,
            };
            return newItem;
        }
    }
}
