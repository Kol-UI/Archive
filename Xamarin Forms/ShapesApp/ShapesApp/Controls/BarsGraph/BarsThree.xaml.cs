using System;
using System.Collections.Generic;
using ShapesApp.ViewModels;
using Xamarin.Forms;

namespace ShapesApp.Controls.BarsGraph
{
    public partial class BarsThree : ContentView
    {
        public BarsThree()
        {
            InitializeComponent();
            BindingContext = new GraphBarsViewModels();
        }
    }
}
