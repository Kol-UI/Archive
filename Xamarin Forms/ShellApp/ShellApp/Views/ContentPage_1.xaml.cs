using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellApp.Views
{
    public partial class ContentPage_1 : ContentPage
    {
        public ContentPage_1()
        {
            InitializeComponent();
        }

        async void ButtonHelpFAQ(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HelpFAQPage());
        }

        async void ButtonNotes(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NotesListPage2());
        }
    }
}
