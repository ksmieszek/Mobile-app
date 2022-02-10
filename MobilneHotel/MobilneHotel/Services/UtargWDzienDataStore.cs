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
    public class UtargWDzienDataStore
    {
        public IService1 hotelService { get; set; }
        public UtargWDzienDataStore()
        {
            hotelService = DependencyService.Get<MobilneHotelServiceReference.IService1>();
        }
      
        public decimal? UtargWDniach(DateTime odDaty, DateTime doDaty)
        {
            return hotelService.UtargWDniach(new UtargWDniachRequest(odDaty, doDaty)).UtargWDniachResult;
        }
    }

}
