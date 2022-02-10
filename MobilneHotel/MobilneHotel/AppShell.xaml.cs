using MobilneHotel.ViewModels;
using MobilneHotel.Views;
using MobilneHotel.Views.Klient;
using MobilneHotel.Views.Pokoj;
using MobilneHotel.Views.Pracownik;
using MobilneHotel.Views.Rezerwacja;
using MobilneHotel.Views.RodzajPokoju;
using MobilneHotel.Views.Raporty;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MobilneHotel
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(KlientIndexPage), typeof(KlientIndexPage));
            Routing.RegisterRoute(nameof(NewKlientPage), typeof(NewKlientPage));
            Routing.RegisterRoute(nameof(PracownikIndexPage), typeof(PracownikIndexPage));
            Routing.RegisterRoute(nameof(NewPracownikPage), typeof(NewPracownikPage));
            Routing.RegisterRoute(nameof(RezerwacjaIndexPage), typeof(RezerwacjaIndexPage));
            Routing.RegisterRoute(nameof(NewRezerwacjaPage), typeof(NewRezerwacjaPage));
            Routing.RegisterRoute(nameof(PokojIndexPage), typeof(PokojIndexPage));
            Routing.RegisterRoute(nameof(NewPokojPage), typeof(NewPokojPage));
            Routing.RegisterRoute(nameof(RodzajPokojuIndexPage), typeof(RodzajPokojuIndexPage));
            Routing.RegisterRoute(nameof(NewRodzajPokojuPage), typeof(NewRodzajPokojuPage));
            Routing.RegisterRoute(nameof(KlientDeleteSuccess), typeof(KlientDeleteSuccess));
            Routing.RegisterRoute(nameof(PracownikDeleteSuccess), typeof(PracownikDeleteSuccess));
            Routing.RegisterRoute(nameof(PokojDeleteSuccess), typeof(PokojDeleteSuccess));
            Routing.RegisterRoute(nameof(RezerwacjaDeleteSuccess), typeof(RezerwacjaDeleteSuccess));
            Routing.RegisterRoute(nameof(RodzajPokojuDeleteSuccess), typeof(RodzajPokojuDeleteSuccess));
            Routing.RegisterRoute(nameof(UtargWDniuPage), typeof(UtargWDniuPage));
            Routing.RegisterRoute(nameof(WartosRezerwacjiKlientaPage), typeof(WartosRezerwacjiKlientaPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
