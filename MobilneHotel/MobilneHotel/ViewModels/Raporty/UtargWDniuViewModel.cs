using MobilneHotel.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobilneHotel.ViewModels.Raporty
{
    public class UtargWDniuViewModel : BaseViewModel
    {
        public Command UtargWDniuCommand { get; }
        public UtargWDniuViewModel()
        {
            UtargWDniuCommand = new Command(ObliczUtarg);
            UtargWDniu = 0;
            DataOd = DateTime.Now;
            DataDo = DateTime.Now;
        }

        private DateTime odDaty;
        public DateTime DataOd
        {
            get => odDaty;
            set => SetProperty(ref odDaty, value);
        }

        private DateTime doDaty;
        public DateTime DataDo
        {
            get => doDaty;
            set => SetProperty(ref doDaty, value);
        }

        private decimal? utargWDniu;
        public decimal? UtargWDniu
        {
            get => utargWDniu;
            set => SetProperty(ref utargWDniu, value);
        }
        private void ObliczUtarg()
        {
            UtargWDniu = new UtargWDzienDataStore().UtargWDniach(odDaty,doDaty);
        }
    }
}
