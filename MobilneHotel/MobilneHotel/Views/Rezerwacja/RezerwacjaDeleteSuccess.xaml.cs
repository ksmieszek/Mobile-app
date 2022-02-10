using MobilneHotel.ViewModels.Rezerwacja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobilneHotelServiceReference;


namespace MobilneHotel.Views.Rezerwacja
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RezerwacjaDeleteSuccess : ContentPage
    {
        RezerwacjaViewModel _viewModel;
        public RezerwacjaDeleteSuccess()
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