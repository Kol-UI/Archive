using System;
using System.Collections.Generic;


using Xamarin.Forms;

namespace ShellApp.Views
{
    public partial class NotesListPage : ContentPage
    {
        ViewCell lastCell;

        public NotesListPage()
        {
            InitializeComponent();

            listViewNotes.ItemsSource = new List<Color>
            {
                Color.Aqua, Color.Black, Color.Blue, Color.Fuchsia,
                Color.Gray, Color.Green, Color.Lime, Color.Maroon,
                Color.Navy, Color.Olive, Color.Pink, Color.Purple,
                Color.Red, Color.Silver, Color.Teal, Color.White, Color.Yellow
            };
        }
        private void ViewCell_Tapped(object sender, System.EventArgs e)
        {
            if (lastCell != null)
                lastCell.View.BackgroundColor = Color.Transparent;
            var viewCell = (ViewCell)sender;
            if (viewCell.View != null)
            {
                viewCell.View.BackgroundColor = Color.Cyan;
                lastCell = viewCell;
            }
        }
    }
}
