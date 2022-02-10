using System;
using System.Collections.Generic;
using System.Text;
using MobilneHotelServiceReference;
using System.Linq;
using Xamarin.Forms;
using MobilneHotel.Views.Pokoj;

namespace MobilneHotel.Services
{
   public class PokojDataStore : ItemDataStore<PokojForView>
    {
        public PokojDataStore()
          : base()
        {
            RefreshList();
        }
       
        public override void Add(PokojForView item)
        {
            if (!service1.AddModifyPokoj(new AddModifyPokojRequest(item)).AddModifyPokojResult)
            {
                App.Current.MainPage.DisplayAlert("Bład", "Dodawanie pokoju się nie powiodło", "Anuluj");
            }
            RefreshList();
        }

        public override void DeleteItem(int IdPokoju)
        {
            if (!service1.DeletePokoj(new DeletePokojRequest(IdPokoju)).DeletePokojResult)
            {
                App.Current.MainPage.DisplayAlert("Błąd", "Nie udało się usunąć pokoju", "Anuluj");
            }
            RefreshList();
            Shell.Current.GoToAsync(nameof(PokojDeleteSuccess));
        }
        public override PokojForView Find(PokojForView item)
        {
            return items.FirstOrDefault(x => x.IdPokoju == item.IdPokoju);
        }

        public override PokojForView Find(int id)
        {
            return items.FirstOrDefault(x => x.IdPokoju == id);
        }

        public override void RefreshList()
        {
            items = service1
                .GetAllPokoje(new GetAllPokojeRequest())
                .GetAllPokojeResult
                .ToList();
        }
    }
}
