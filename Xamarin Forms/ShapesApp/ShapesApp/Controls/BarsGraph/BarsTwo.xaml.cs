using System;
using System.Collections.Generic;
using ShapesApp.ViewModels;
using Xamarin.Forms;

namespace ShapesApp.Controls.BarsGraph
{
    public partial class BarsTwo : ContentView
    {
        public BarsTwo()
        {
            InitializeComponent();
            BindingContext = new GraphBarsViewModels();
        }
    }
}
