using System;
using System.Collections.Generic;
using RectSearch.ViewModels;
using RectSearch.Models;
using Xamarin.Forms;
using Xamarin.CommunityToolkit;

namespace RectSearch.Controls
{
    public partial class RectSearchControl : ContentView
    {
        public RectSearchControl()
        {
            InitializeComponent();
            BindingContext = new RectViewModel();
        }

        void Gbutton_Pressed(System.Object sender, System.EventArgs e)
        {
            MainRectangle.Fill = Brush.Green;
        }

        void Rbutton_Pressed(System.Object sender, System.EventArgs e)
        {
            MainRectangle.Fill = Brush.Red;
        }

        void Bbutton_Pressed(System.Object sender, System.EventArgs e)
        {
            MainRectangle.Fill = Brush.Blue;
        }
    }
}
