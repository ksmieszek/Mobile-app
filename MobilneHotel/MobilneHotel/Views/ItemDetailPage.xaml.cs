using MobilneHotel.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MobilneHotel.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}