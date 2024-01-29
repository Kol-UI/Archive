using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ShapesApp.Controls;
using ShapesApp.Models;
using ShapesApp.ViewModels;
using Xamarin.Forms;

namespace ShapesApp.Controls
{
    public partial class ProgressFrames : ContentView
    {
        public ProgressFrames()
        {
            InitializeComponent();
            BindingContext = new DecksProgress();
            MainCollectionViewProgress.ItemsSource = DecksProgress.GetAllProgressFrames();
        }
    }

}
