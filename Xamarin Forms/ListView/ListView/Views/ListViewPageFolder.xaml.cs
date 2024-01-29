using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ListView.Classes;
using ListView.Models;
using ListView.Views;
using Xamarin.Forms;

namespace ListView.Views
{
    public partial class ListViewPageFolder : INotifyPropertyChanged
    {
        public ListViewPageFolder(ObservableCollection<noteItem> ItemsCollection)
        {
            InitializeComponent();
            BindingContext = this;
            listViewItems.ItemsSource = ItemsCollection;
        }
    }
}
