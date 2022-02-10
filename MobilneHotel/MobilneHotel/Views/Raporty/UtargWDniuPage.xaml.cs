using MobilneHotel.ViewModels.Raporty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobilneHotel.Views.Raporty
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UtargWDniuPage : ContentPage
    {
        UtargWDniuViewModel _viewModel;
        public UtargWDniuPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new UtargWDniuViewModel();
        }
    }
}