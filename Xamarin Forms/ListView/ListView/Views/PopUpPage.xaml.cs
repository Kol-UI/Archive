using System;
using System.Collections.Generic;
using ListView.Controls;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;

namespace ListView.Views
{
    public partial class PopUpPage : ContentPage
    {
        public PopUpPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushPopupAsync(new FirstPopUpPage());
        }
    }
}
