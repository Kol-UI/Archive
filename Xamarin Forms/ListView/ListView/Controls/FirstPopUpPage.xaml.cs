﻿using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListView.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPopUpPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        public FirstPopUpPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopPopupAsync();
        }
    }
}
