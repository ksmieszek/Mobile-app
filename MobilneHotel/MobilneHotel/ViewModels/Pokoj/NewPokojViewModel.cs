using MobilneHotel.Services;
using MobilneHotelServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobilneHotel.ViewModels.Pokoj
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class NewPokojViewModel : ANewItemViewModel<PokojForView>
    {
        public IDataStore<PokojForView> DataStore => DependencyService.Get<IDataStore<PokojForView>>();//edycja
        private RodzajPokojuForView selectedRodzajPokoju;
        private int itemId;//edycja
        private string nrPokoju;
        private int pietro;
        private string nazwa;
        private decimal cena;
        private string status;
        private int idPokoju;

        public List<RodzajPokojuForView> RodzajePokojow
        {
            get
            {
                var rodzajPokojuStore = DependencyService.Get<ItemDataStore<RodzajPokojuForView>>();
                return rodzajPokojuStore.items;
            }
        }

        public NewPokojViewModel()
            : base()
        {
            selectedRodzajPokoju = new RodzajPokojuForView();
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
                idPokoju = item.IdPokoju;
                Nazwa = item.Nazwa;
                NrPokoju = item.NrPokoju;
                Pietro = (int)item.Pietro;
                Status = item.Status;
                Cena = (decimal)item.Cena;
                var indexInList = RodzajePokojow.FindIndex(x => x.IdRodzajuPokoju == item.IdRodzajuPokoju);
                SelectedRodzajPokoju = RodzajePokojow[indexInList];
        }

        public override bool ValidateSave()
        {
            return !string.IsNullOrWhiteSpace(selectedRodzajPokoju.Nazwa);
        }

        public RodzajPokojuForView SelectedRodzajPokoju
        {
            get => selectedRodzajPokoju;
            set => SetProperty(ref selectedRodzajPokoju, value);
        }
        public int IdPokoju
        {
            get => idPokoju;
            set => SetProperty(ref idPokoju, value);
        }
        public string Nazwa
        {
            get => nazwa;
            set => SetProperty(ref nazwa, value);
        }
        public decimal Cena
        {
            get => cena;
            set => SetProperty(ref cena, value);
        }
        public string NrPokoju
        {
            get => nrPokoju;
            set => SetProperty(ref nrPokoju, value);
        }
        public int Pietro
        {
            get => pietro;
            set => SetProperty(ref pietro, value);
        }
        public string Status
        {
            get => status;
            set => SetProperty(ref status, value);
        }
        public override PokojForView SetItem()
        {
            var newItem = new PokojForView()
            {
                IdPokoju = IdPokoju,
                Nazwa = Nazwa,
                Cena = Cena,
                NrPokoju = NrPokoju,
                Pietro = Pietro,
                Status = Status,
                IdRodzajuPokoju = SelectedRodzajPokoju.IdRodzajuPokoju,
                RodzajPokojuDane = $"{selectedRodzajPokoju.Nazwa}",
            };
            return newItem;
        }
    }
}
