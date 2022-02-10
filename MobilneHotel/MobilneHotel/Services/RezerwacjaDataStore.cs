using MobilneHotel.Views.Rezerwacja;
using MobilneHotelServiceReference;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobilneHotel.Services
{
    public class RezerwacjaDataStore : ItemDataStore<RezerwacjaForView>
    {
        public RezerwacjaDataStore()
           : base()
        {
            RefreshList();
        }
        public override void Add(RezerwacjaForView item)
        {
            if (!service1.AddModifyRezerwacja(new AddModifyRezerwacjaRequest(item)).AddModifyRezerwacjaResult)
            {
                App.Current.MainPage.DisplayAlert("Bład", "Dodawanie rezerwacji się nie powiodło", "Anuluj");
            }
            RefreshList();
        }
        public override void DeleteItem(int IdRezerwacji)
        {
            if (!service1.DeleteRezerwacja(new DeleteRezerwacjaRequest(IdRezerwacji)).DeleteRezerwacjaResult)
            {
                App.Current.MainPage.DisplayAlert("Błąd", "Nie udało się usunąć rezerwacji", "Anuluj");
            }
            RefreshList();
            Shell.Current.GoToAsync(nameof(RezerwacjaDeleteSuccess));
        }
        public override RezerwacjaForView Find(RezerwacjaForView item)
        {
            return items.FirstOrDefault(x => x.IdRezerwacji == item.IdRezerwacji);
        }

        public override RezerwacjaForView Find(int id)
        {
            return items.FirstOrDefault(x => x.IdRezerwacji == id);
        }

        public override void RefreshList()
        {
            items = service1
                .GetAllRezerwacje(new GetAllRezerwacjeRequest())
                .GetAllRezerwacjeResult
                .ToList();
        }
    }
}
