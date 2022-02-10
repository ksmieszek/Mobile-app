using MobilneHotel.ViewModels.RodzajPokoju;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilneHotel.Views.RodzajPokoju
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RodzajPokojuIndexPage : ContentPage
    {
        RodzajPokojuViewModel _viewModel;
        public RodzajPokojuIndexPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new RodzajPokojuViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}