using System;
using System.Collections.Generic;
using CollectionViewTutorial.ViewModels;
using CollectionViewTutorial.Views;
using Xamarin.Forms;

namespace CollectionViewTutorial
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
