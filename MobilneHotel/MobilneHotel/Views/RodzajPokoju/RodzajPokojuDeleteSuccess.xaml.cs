using MobilneHotel.ViewModels.RodzajPokoju;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilneHotel.Views.RodzajPokoju
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RodzajPokojuDeleteSuccess : ContentPage
    {
        RodzajPokojuViewModel _viewModel;
        public RodzajPokojuDeleteSuccess()
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