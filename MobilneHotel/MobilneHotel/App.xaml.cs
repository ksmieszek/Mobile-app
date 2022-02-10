using MobilneHotel.Services;
using MobilneHotel.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilneHotel
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            DependencyService.Register<KlientDataStore>();
            DependencyService.Register<PracownikDataStore>();
            DependencyService.Register<RezerwacjaDataStore>();
            DependencyService.Register<PokojDataStore>();
            DependencyService.Register<RodzajPokojuDataStore>();
            DependencyService.Register<UtargWDzienDataStore>();
            DependencyService.Register<MobilneHotelServiceReference.Service1Client>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
