using MobilneHotel.ViewModels.Pokoj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilneHotel.Views.Pokoj
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokojDeleteSuccess : ContentPage
    {
        PokojViewModel _viewModel;
        public PokojDeleteSuccess()
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