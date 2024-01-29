using System;
using System.Collections.Generic;
using Sharpnado.Shades;
using Sharpnado;

using Xamarin.Forms;

namespace ListView.Views
{
    public partial class UserProfile : ContentPage
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        async void TapGestureRecognizer_Tasks(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new TasksMenu());
        }

        async void TapGestureRecognizer_Stats(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GlobalStatsView());
        }
    }
}
