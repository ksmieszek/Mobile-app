using MobilneHotel.ViewModels.RodzajPokoju;
using MobilneHotelServiceReference;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilneHotel.Views.RodzajPokoju
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewRodzajPokojuPage : ContentPage
    {
        public RodzajPokojuForView Item { get; set; }
        public NewRodzajPokojuPage()
        {
            InitializeComponent();
            BindingContext = new NewRodzajPokojuViewModel();
        }
    }
}