using System.ComponentModel;
using Xamarin.Forms;
using JobPortal.ViewModels;

namespace JobPortal.Views
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
