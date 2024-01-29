using System.ComponentModel;
using Xamarin.Forms;
using ListView.ViewModels;

namespace ListView.Views
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
