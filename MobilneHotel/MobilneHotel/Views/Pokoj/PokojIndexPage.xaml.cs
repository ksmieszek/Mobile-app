using MobilneHotel.ViewModels.Pokoj;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilneHotel.Views.Pokoj
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokojIndexPage : ContentPage
    {
        PokojViewModel _viewModel;
        public PokojIndexPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new PokojViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}