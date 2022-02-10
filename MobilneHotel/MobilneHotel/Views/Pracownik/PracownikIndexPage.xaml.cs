using MobilneHotel.ViewModels.Pracownik;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilneHotel.Views.Pracownik
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PracownikIndexPage : ContentPage
    {
        PracownikViewModel _viewModel;
        public PracownikIndexPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PracownikViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}