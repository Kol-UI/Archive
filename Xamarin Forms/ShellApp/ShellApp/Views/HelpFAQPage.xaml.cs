using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ShellApp.Views
{
    public partial class HelpFAQPage : ContentPage
    {
        public HelpFAQPage()
        {
            InitializeComponent();
        }

        async void ButtonPart1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Help_Part1());
        }

        async void ButtonPart2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Help_Part2());
        }

        async void ButtonPart3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Help_Part3());
        }

        async void ButtonPart4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Help_Part4());
        }

        async void ButtonPart5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Help_Part5());
        }

        async void ButtonPart6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Help_Part6());
        }
    }
}
