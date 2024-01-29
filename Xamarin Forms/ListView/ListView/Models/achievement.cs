using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace ListView.Models
{
    public class achievement : INotifyPropertyChanged
    {
        public string Text { get; set; }
        public bool Check { get; set; }
        public Color AchColor { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
