using ListView.Models;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListView.ViewModels
{
    public class NoteItemViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<noteItem> _noteItems { get; set; }

        public ObservableCollection<noteItem> NoteItems
        {
            get { return _noteItems; }
            set
            {
                _noteItems = value;
                OnPropertyChanged("NoteItems");
            }
        }


        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<noteItem> ItemsCollection = new ObservableCollection<noteItem>()
        {
                new noteItem { ID = 1, Name = "MVVM Test", ItemColor = (Color)Application.Current.Resources["AppColorsRed"]},
                new noteItem { ID = 2, Name = "Test2", ItemColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new noteItem { ID = 3, Name = "Test3", ItemColor = (Color)Application.Current.Resources["AppColorsBlue"]},
                new noteItem { ID = 4, Name = "Test4", ItemColor = (Color)Application.Current.Resources["AppColorsYellow"]},
                new noteItem { ID = 5, Name = "Test5", ItemColor = (Color)Application.Current.Resources["AppColorsBrightOrange"]},
                new noteItem { ID = 6, Name = "Test6", ItemColor = (Color)Application.Current.Resources["AppColorsPurple"]},
         };

        public NoteItemViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
