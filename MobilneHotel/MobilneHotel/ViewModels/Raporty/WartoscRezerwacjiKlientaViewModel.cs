using MobilneHotel.Services;
using MobilneHotelServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobilneHotel.ViewModels.Raporty
{
    public class WartoscRezerwacjiKlientaViewModel : BaseViewModel
    {
        public Command WartoscRezerwacjiKlientaCommand { get; }
        private KlientForView selectedKlient;
        public WartoscRezerwacjiKlientaViewModel()
        {
            WartoscRezerwacjiKlientaCommand = new Command(ObliczWartosc);
            WartoscRezerwacjiKlienta = 0;
            selectedKlient = new KlientForView();
            IdKlienta = selectedKlient.IdKlienta;
        }
        private int idKlienta;
        public int IdKlienta
        {
            get => idKlienta;
            set => SetProperty(ref idKlienta, value);
        }
        public List<KlientForView> Klienci
        {
            get
            {
                var klientStore = DependencyService.Get<ItemDataStore<KlientForView>>();
                return klientStore.items;
            }
        }
        public KlientForView SelectedKlient
        {
            get => selectedKlient;
            set => SetProperty(ref selectedKlient, value);
        }

        private decimal? wartoscRezerwacjiKlienta;
        public decimal? WartoscRezerwacjiKlienta
        {
            get => wartoscRezerwacjiKlienta;
            set => SetProperty(ref wartoscRezerwacjiKlienta, value);
        }
        private void ObliczWartosc()
        {
            WartoscRezerwacjiKlienta = new WartoscRezerwacjiKlientaDataStore().WartoscRezerwacjiKlienta(selectedKlient.IdKlienta);
        }
    }
}
