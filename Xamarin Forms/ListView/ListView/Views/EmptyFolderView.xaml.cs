using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ListView.Views
{
    public partial class EmptyFolderView : ContentPage
    {
        public EmptyFolderView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Shell.SetTabBarIsVisible(this, false);
            Shell.SetNavBarIsVisible(this, true);
            NavigationPage.SetHasBackButton(this, true);
        }   

        async void TapGestureRecognizer_ManageMyAccount(System.Object sender, System.EventArgs e)
        {
            await Browser.OpenAsync("https://learn.microsoft.com/en-us/xamarin/xamarin-forms/", new BrowserLaunchOptions
            {
                LaunchMode = BrowserLaunchMode.SystemPreferred,
                TitleMode = BrowserTitleMode.Hide,
                PreferredControlColor = (Color)Application.Current.Resources["AppColorsWhite"],
                PreferredToolbarColor = (Color)Application.Current.Resources["MainColor"]
            });
        }

        async void TapGestureRecognizer_HowToScan(System.Object sender, System.EventArgs e)
        {
            await Browser.OpenAsync("https://learn.microsoft.com/en-us/xamarin/xamarin-forms/", new BrowserLaunchOptions
            {
                LaunchMode = BrowserLaunchMode.SystemPreferred,
                TitleMode = BrowserTitleMode.Hide,
                PreferredControlColor = (Color)Application.Current.Resources["AppColorsWhite"],
                PreferredToolbarColor = (Color)Application.Current.Resources["MainColor"]
            });
        }

        async void TapGestureRecognizer_ManageMyScans(System.Object sender, System.EventArgs e)
        {
            await Browser.OpenAsync("https://learn.microsoft.com/en-us/xamarin/xamarin-forms/", new BrowserLaunchOptions
            {
                LaunchMode = BrowserLaunchMode.SystemPreferred,
                TitleMode = BrowserTitleMode.Hide,
                PreferredControlColor = (Color)Application.Current.Resources["AppColorsWhite"],
                PreferredToolbarColor = (Color)Application.Current.Resources["MainColor"]
            });
        }

        async void TapGestureRecognizer_PrepareExams(System.Object sender, System.EventArgs e)
        {
            await Browser.OpenAsync("https://learn.microsoft.com/en-us/xamarin/xamarin-forms/", new BrowserLaunchOptions
            {
                LaunchMode = BrowserLaunchMode.SystemPreferred,
                TitleMode = BrowserTitleMode.Hide,
                PreferredControlColor = (Color)Application.Current.Resources["AppColorsWhite"],
                PreferredToolbarColor = (Color)Application.Current.Resources["MainColor"]
            });
        }

        async void TapGestureRecognizer_OtherDevices(System.Object sender, System.EventArgs e)
        {
            await Browser.OpenAsync("https://learn.microsoft.com/en-us/xamarin/xamarin-forms/", new BrowserLaunchOptions
            {
                LaunchMode = BrowserLaunchMode.SystemPreferred,
                TitleMode = BrowserTitleMode.Hide,
                PreferredControlColor = (Color)Application.Current.Resources["AppColorsWhite"],
                PreferredToolbarColor = (Color)Application.Current.Resources["MainColor"]
            });
        }

        async void TapGestureRecognizer_SmartFeatures(System.Object sender, System.EventArgs e)
        {
            await Browser.OpenAsync("https://learn.microsoft.com/en-us/xamarin/xamarin-forms/", new BrowserLaunchOptions
            {
                LaunchMode = BrowserLaunchMode.SystemPreferred,
                TitleMode = BrowserTitleMode.Hide,
                PreferredControlColor = (Color)Application.Current.Resources["AppColorsWhite"],
                PreferredToolbarColor = (Color)Application.Current.Resources["MainColor"]
            });
        }
    }
}
