using System;
using System.Collections.Generic;
using ShapesApp.ViewModels;
using Xamarin.Forms;

namespace ShapesApp.Controls
{
    public partial class CurrentStockageStatsFrame : ContentView
    {
        public CurrentStockageStatsFrame()
        {
            InitializeComponent();
            BindingContext = new UserInfoDataViewModel();
        }
    }
}
