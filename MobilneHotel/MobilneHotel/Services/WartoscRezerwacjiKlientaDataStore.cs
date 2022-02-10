using System;
using System.Collections.Generic;
using System.Text;
using MobilneHotel.Views.Klient;
using MobilneHotelServiceReference;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobilneHotel.Services
{
    public class WartoscRezerwacjiKlientaDataStore
    {
        public IService1 hotelService { get; set; }
        public WartoscRezerwacjiKlientaDataStore()
        {
            hotelService = DependencyService.Get<MobilneHotelServiceReference.IService1>();
        }

        public decimal? WartoscRezerwacjiKlienta(int idKlienta)
        {
            return hotelService.WartoscRezerwacjiKlienta(new WartoscRezerwacjiKlientaRequest(idKlienta)).WartoscRezerwacjiKlientaResult;
        }
    }
}
