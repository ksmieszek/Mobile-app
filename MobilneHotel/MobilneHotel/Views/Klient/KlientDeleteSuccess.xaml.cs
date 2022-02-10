using MobilneHotel.ViewModels.Klient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobilneHotelServiceReference;

namespace MobilneHotel.Views.Klient
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KlientDeleteSuccess : ContentPage
    {
        KlientViewModel _viewModel;
        public KlientDeleteSuccess()
        {
            InitializeComponent();
            BindingContext = _viewModel = new KlientViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}