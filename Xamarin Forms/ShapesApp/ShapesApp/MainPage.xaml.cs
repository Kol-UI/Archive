using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ShapesApp.Controls;
using ShapesApp.Models;
using ShapesApp.ViewModels;

namespace ShapesApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new GraphBarsViewModels();
        }
    }
}
