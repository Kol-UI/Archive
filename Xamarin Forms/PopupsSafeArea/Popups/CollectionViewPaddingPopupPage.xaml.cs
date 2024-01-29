using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace AwesomeApp.Popups
{	
	public partial class CollectionViewPaddingPopupPage : PopupPage
    {
        private ObservableCollection<string> newItems;

        public CollectionViewPaddingPopupPage()
		{
			InitializeComponent ();
            BindingContext = this;

            newItems = new ObservableCollection<string>
            {
                "Option 1", "Option 2", "Option 3",
                "Test", "Another Test", "Yet Another Test"
            };

            ListViewFilter.ItemsSource = newItems;
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Alert", "You have been alerted", "OK");
        }
    }
}

