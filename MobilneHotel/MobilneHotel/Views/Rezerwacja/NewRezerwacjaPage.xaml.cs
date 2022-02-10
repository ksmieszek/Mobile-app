using MobilneHotel.ViewModels.Rezerwacja;
using MobilneHotelServiceReference;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilneHotel.Views.Rezerwacja
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewRezerwacjaPage : ContentPage
    {
        public RezerwacjaForView Item { get; set; }
        public NewRezerwacjaPage()
        {
            InitializeComponent();
            BindingContext = new NewRezerwacjaViewModel();
        }
    }
}