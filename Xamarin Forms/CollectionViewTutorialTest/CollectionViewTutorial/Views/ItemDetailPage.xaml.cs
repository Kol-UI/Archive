using System.ComponentModel;
using Xamarin.Forms;
using CollectionViewTutorial.ViewModels;

namespace CollectionViewTutorial.Views
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