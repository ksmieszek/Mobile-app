using MobilneHotel.ViewModels.Klient;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilneHotel.Views.Klient
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KlientIndexPage : ContentPage
    {
        KlientViewModel _viewModel;
        public KlientIndexPage()
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