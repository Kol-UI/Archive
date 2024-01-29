using System;
using System.Collections.Generic;
using ShapesApp.ViewModels;
using Xamarin.Forms;

namespace ShapesApp.Controls
{
    public partial class StatsFrame : ContentView
    {
        public StatsFrame()
        {
            InitializeComponent();
            BindingContext = new UserInfoDataViewModel();
        }
    }
}
