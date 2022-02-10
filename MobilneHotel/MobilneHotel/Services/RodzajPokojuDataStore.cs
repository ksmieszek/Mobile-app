using MobilneHotelServiceReference;
using System.Linq;
using MobilneHotel.Views.RodzajPokoju;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobilneHotel.Services
{
    public class RodzajPokojuDataStore : ItemDataStore<RodzajPokojuForView>
    {
        public RodzajPokojuDataStore()
        : base()
        {
            RefreshList();
        }
        public override void Add(RodzajPokojuForView item)
        {
            if (!service1.AddModifyRodzajPokoju(new AddModifyRodzajPokojuRequest(item)).AddModifyRodzajPokojuResult)
            {
                App.Current.MainPage.DisplayAlert("Błąd", "Dodawanie rodzaju pokoju się nie powiodło", "Anuluj");
            }
            RefreshList();
        }
        public override void DeleteItem(int IdRodzajuPokoju)
        {
            if (!service1.DeleteRodzajPokoju(new DeleteRodzajPokojuRequest(IdRodzajuPokoju)).DeleteRodzajPokojuResult)
            {
                App.Current.MainPage.DisplayAlert("Błąd", "Nie udało się usunąć rodzaju pokoju", "Anuluj");
            }
            RefreshList();
            Shell.Current.GoToAsync(nameof(RodzajPokojuDeleteSuccess));
        }

        public override RodzajPokojuForView Find(RodzajPokojuForView item)
        {
            return items.Where((RodzajPokojuForView arg) => arg.IdRodzajuPokoju == item.IdRodzajuPokoju).FirstOrDefault();
        }

        public override RodzajPokojuForView Find(int id)
        {
            return items.Where((RodzajPokojuForView arg) => arg.IdRodzajuPokoju == id).FirstOrDefault();
        }

        public override void RefreshList()
        {
            items = service1.GetAllRodzajePokojow(new GetAllRodzajePokojowRequest())
                .GetAllRodzajePokojowResult
                .ToList();
        }
    }
}
