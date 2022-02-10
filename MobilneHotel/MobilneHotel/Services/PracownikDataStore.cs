using MobilneHotel.Views.Pracownik;
using MobilneHotelServiceReference;
using System.Linq;
using Xamarin.Forms;

namespace MobilneHotel.Services
{
    public class PracownikDataStore : ItemDataStore<PracownikForView>
    {
        public PracownikDataStore()
         : base()
        {
            RefreshList();
        }

        public override void Add(PracownikForView item)
        {
            if (!service1.AddModifyPracownik(new AddModifyPracownikRequest(item)).AddModifyPracownikResult)
            {
                App.Current.MainPage.DisplayAlert("Bład", "Dodawanie pracownika się nie powiodło", "Anuluj");
            }
            RefreshList();
        }
        public override void DeleteItem(int IdPracownika)
        {
            if (!service1.DeletePracownik(new DeletePracownikRequest(IdPracownika)).DeletePracownikResult)
            {
                App.Current.MainPage.DisplayAlert("Błąd", "Nie udało się usunąć pracownika", "Anuluj");
            }
            RefreshList();
            Shell.Current.GoToAsync(nameof(PracownikDeleteSuccess));
        }
        public override PracownikForView Find(PracownikForView item)
        {
            return items.Where((PracownikForView arg) => arg.IdPracownika == item.IdPracownika).FirstOrDefault();
        }

        public override PracownikForView Find(int id)
        {
            return items.Where((PracownikForView arg) => arg.IdPracownika == id).FirstOrDefault();
        }

        public override void RefreshList()
        {
            items = service1.GetAllPracownicy(new GetAllPracownicyRequest())
                .GetAllPracownicyResult
                .ToList();
        }

    }
}





