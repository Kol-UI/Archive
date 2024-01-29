using System;
using System.ComponentModel;
using RectSearch.Models;
using Xamarin.Forms;

namespace RectSearch.ViewModels
{
    public class RectViewModel : INotifyPropertyChanged
    {
        private RectModel rectModel;
        public RectViewModel()
        {
            rectModel = new RectModel()
            {
                SearchColor = Brush.Gray,
            };

        }

        public Brush SearchColor
        {
            get { return rectModel.SearchColor; }
            set
            {
                if (rectModel.SearchColor != value)
                {
                    rectModel.SearchColor = Brush.Gray;
                    OnPropertyChange("SearchColor");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
