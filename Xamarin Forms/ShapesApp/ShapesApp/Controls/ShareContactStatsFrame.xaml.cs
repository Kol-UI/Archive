using System;
using System.Collections.Generic;
using ShapesApp.ViewModels;
using Xamarin.Forms;

namespace ShapesApp.Controls
{
    public partial class ShareContactStatsFrame : ContentView
    {
        public ShareContactStatsFrame()
        {
            InitializeComponent();
            BindingContext = new UserInfoDataViewModel();
        }
    }
}
