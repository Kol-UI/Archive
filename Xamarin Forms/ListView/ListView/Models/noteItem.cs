using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace ListView.Models
{
    public class noteItem : INotifyPropertyChanged
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Color ItemColor { get; set; }
        public int SubFolderID { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
