using MobilneHotel.ViewModels.Pracownik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilneHotel.Views.Pracownik
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PracownikDeleteSuccess : ContentPage
    {
        PracownikViewModel _viewModel;
        public PracownikDeleteSuccess()
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