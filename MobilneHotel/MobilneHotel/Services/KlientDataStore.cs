using MobilneHotel.Views.Klient;
using MobilneHotelServiceReference;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobilneHotel.Services
{
    public class KlientDataStore : ItemDataStore<KlientForView>
    {
        public KlientDataStore()
          : base()
        {
            RefreshList();
        }
    
        public override void Add(KlientForView item)
        {
            if (!service1.AddModifyKlient(new AddModifyKlientRequest(item)).AddModifyKlientResult)
            {
                App.Current.MainPage.DisplayAlert("Błąd", "Dodawanie klienta się nie powiodło", "Anuluj");
            }
            RefreshList();
        }
        public override void DeleteItem(int IdKlienta)
        {
            if (!service1.DeleteKlient(new DeleteKlientRequest(IdKlienta)).DeleteKlientResult)
            {
                App.Current.MainPage.DisplayAlert("Błąd", "Nie udało się usunąć klienta", "Anuluj");
            }
            RefreshList();
            Shell.Current.GoToAsync(nameof(KlientDeleteSuccess));
        }

        public override KlientForView Find(KlientForView item)
        {
            return items.Where((KlientForView arg) => arg.IdKlienta == item.IdKlienta).FirstOrDefault();
        }

        public override KlientForView Find(int id)
        {
            return items.Where((KlientForView arg) => arg.IdKlienta == id).FirstOrDefault();
        }

        public override void RefreshList()
        {
            items = service1.GetAllKlienci(new GetAllKlienciRequest())
                .GetAllKlienciResult
                .ToList();
        }
    }

}

