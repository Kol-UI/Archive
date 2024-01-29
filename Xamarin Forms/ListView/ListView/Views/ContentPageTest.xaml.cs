using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListView.Views
{
    public partial class ContentPageTest : ContentPage
    {
        public ContentPageTest()
        {
            InitializeComponent();
        }

        void Button_CancelSharing(System.Object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        void Button_ValidateSharing(System.Object sender, System.EventArgs e)
        {
            _ = AlertSharingItem();
        }

        async Task AlertSharingItem()
        {
            bool answer = await DisplayAlert("Sharing", "Are you sure about sharing ?", "Yes !", "Nevermind");
            if (answer == false)
            {
                await DisplayAlert("Alert", "Canceling...", "OK");
                _ = Navigation.PopModalAsync();
            }
            if (answer == true)
            {
                await DisplayAlert("Alert", "Sharing...", "OK");
                _ = Navigation.PopModalAsync();
            }
        }
    }

    
    
}
