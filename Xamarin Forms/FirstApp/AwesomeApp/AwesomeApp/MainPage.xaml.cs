using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Rg.Plugins.Popup.Services;
using AwesomeApp.Popups;
using Rg.Plugins.Popup.Extensions;

namespace AwesomeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // This is optional, but provides better layout for the iPhone X 
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        int count = 0;
        private async void Button_Clicked(object sender, EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";

            //await Device.InvokeOnMainThreadAsync(async () => await Navigation.PushPopupAsync(new PopupOptionsPage()));
            await PopupNavigation.Instance.PushAsync(new PopupOptionsPage());
            //await Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new PopupOptionsPage());
        }

        async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new OptionsPopupPage());
        }

        async void Button_Clicked_SystemPadding(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new SystemPaddingPopupPage());
        }

        async void Button_Clicked_CollectionView(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new CollectionViewPaddingPopupPage());
        }

        async void Button_Clicked_StackLayout(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new StackLayoutPopupPage());
        }
    }
}
