using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListView.Controls
{
    public partial class ColorPicker : ContentView
    {
        public static readonly BindableProperty FrameBackgroundColorProperty = BindableProperty.Create(nameof(FrameBackgroundColor), typeof(Color), typeof(ColorPicker), (Color)Application.Current.Resources["AppColorsViolet"]);

        public Color FrameBackgroundColor
        {
            get => (Color)GetValue(FrameBackgroundColorProperty);
            set => SetValue(FrameBackgroundColorProperty, value);
        }

        public ColorPicker()
        {
            InitializeComponent();
        }
    }
}
