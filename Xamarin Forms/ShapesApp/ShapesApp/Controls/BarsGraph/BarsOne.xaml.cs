using System;
using System.Collections.Generic;
using ShapesApp.ViewModels;
using Xamarin.Forms;

namespace ShapesApp.Controls.BarsGraph
{
    public partial class BarsOne : ContentView
    {
        public BarsOne()
        {
            InitializeComponent();
            BindingContext = new GraphBarsViewModels();
        }
    }
}
