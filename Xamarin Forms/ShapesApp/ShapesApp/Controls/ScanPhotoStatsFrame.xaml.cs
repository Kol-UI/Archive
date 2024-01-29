using System;
using System.Collections.Generic;
using ShapesApp.ViewModels;
using Xamarin.Forms;

namespace ShapesApp.Controls
{
    public partial class ScanPhotoStatsFrame : ContentView
    {
        public ScanPhotoStatsFrame()
        {
            InitializeComponent();
            BindingContext = new UserInfoDataViewModel();

        }
    }
}
