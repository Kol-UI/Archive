using System;
using System.Collections.Generic;
using ShapesApp.ViewModels;
using Xamarin.Forms;

namespace ShapesApp.Controls
{
    public partial class InfoStats : ContentView
    {
        public InfoStats()
        {
            InitializeComponent();
            BindingContext = new InfoStatsViewModel();
        }
    }
}
