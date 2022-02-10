using MobilneHotel.ViewModels.Pracownik;
using MobilneHotelServiceReference;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilneHotel.Views.Pracownik
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPracownikPage : ContentPage
    {
        public PracownikForView Item { get; set; }
        public NewPracownikPage()
        {
            InitializeComponent();
            BindingContext = new NewPracownikViewModel();
        }
    }
}