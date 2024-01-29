using System;
using System.Collections.Generic;
using ShapesApp.ViewModels;
using Xamarin.Forms;

namespace ShapesApp.Controls
{
    public partial class ProfileSecurityStatsFrame : ContentView
    {
        public ProfileSecurityStatsFrame()
        {
            InitializeComponent();
            BindingContext = new UserInfoDataViewModel();

        }
    }
}
