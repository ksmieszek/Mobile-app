using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilneHotel.ViewModels.Raporty;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilneHotel.Views.Raporty
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WartosRezerwacjiKlientaPage : ContentPage
    {
        WartoscRezerwacjiKlientaViewModel _viewModel;
        public WartosRezerwacjiKlientaPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new WartoscRezerwacjiKlientaViewModel();
        }
    }
}