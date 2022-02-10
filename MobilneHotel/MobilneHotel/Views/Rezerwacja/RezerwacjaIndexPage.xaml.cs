using MobilneHotel.ViewModels.Rezerwacja;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilneHotel.Views.Rezerwacja
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RezerwacjaIndexPage : ContentPage
    {
        RezerwacjaViewModel _viewModel;
        public RezerwacjaIndexPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new RezerwacjaViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}