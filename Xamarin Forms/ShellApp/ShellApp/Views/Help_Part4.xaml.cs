﻿using System;
using System.Collections.Generic;
using Xamarin.Essentials;

using Xamarin.Forms;

namespace ShellApp.Views
{
    public partial class Help_Part4 : ContentPage
    {
        public Help_Part4()
        {
            InitializeComponent();
        }

        //using Xamarin.Essentials
        private async void Open_Article_4_1(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://learn.microsoft.com/en-us/xamarin/xamarin-forms/", BrowserLaunchMode.SystemPreferred);
        }

        private async void Open_Article_4_2(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://learn.microsoft.com/en-us/xamarin/xamarin-forms/", BrowserLaunchMode.SystemPreferred);
        }

        private async void Open_Article_4_3(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://learn.microsoft.com/en-us/xamarin/xamarin-forms/", BrowserLaunchMode.SystemPreferred);
        }

        private async void Open_Article_4_4(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://learn.microsoft.com/en-us/xamarin/xamarin-forms/", BrowserLaunchMode.SystemPreferred);
        }
    }
}
