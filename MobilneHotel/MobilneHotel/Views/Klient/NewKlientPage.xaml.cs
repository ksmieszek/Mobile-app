using MobilneHotel.ViewModels.Klient;
using MobilneHotelServiceReference;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilneHotel.Views.Klient
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewKlientPage : ContentPage
    {
        public KlientForView Item { get; set; }
        public NewKlientPage()
        {
            InitializeComponent();
            BindingContext = new NewKlientViewModel();
        }
    }
}