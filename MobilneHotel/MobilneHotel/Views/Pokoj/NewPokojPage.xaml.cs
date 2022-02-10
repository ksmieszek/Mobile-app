using MobilneHotel.ViewModels.Pokoj;
using MobilneHotelServiceReference;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilneHotel.Views.Pokoj
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPokojPage : ContentPage
    {
        public PokojForView Item { get; set; }
        public NewPokojPage()
        {
            InitializeComponent();
            BindingContext = new NewPokojViewModel();
        }
    }
}