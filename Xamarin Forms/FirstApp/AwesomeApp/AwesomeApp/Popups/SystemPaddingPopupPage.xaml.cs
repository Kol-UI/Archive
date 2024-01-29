using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace AwesomeApp.Popups
{	
	public partial class SystemPaddingPopupPage : PopupPage
    {
        private ObservableCollection<string> newItems;

        public SystemPaddingPopupPage()
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
	}
}