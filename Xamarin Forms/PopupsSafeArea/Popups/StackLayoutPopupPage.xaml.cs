using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace AwesomeApp.Popups
{	
	public partial class StackLayoutPopupPage : PopupPage
    {
        private ObservableCollection<string> newItems;

        public StackLayoutPopupPage ()
		{
			InitializeComponent ();
            BindingContext = this;

            newItems = new ObservableCollection<string>
            {
                "Example 1", "Example 2",
                "Option 1", "Option 2", "Option 3",
                "Option 4",
                "Test", "Another Test", "Yet Another Test",
            };

            BindableLayout.SetItemsSource(StackLayoutBinding, newItems);

            
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Alert", "You have been alerted", "OK");
        }
    }
}

