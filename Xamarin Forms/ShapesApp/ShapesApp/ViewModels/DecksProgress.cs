using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ShapesApp.Models;
using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using ShapesApp.Controls;

namespace ShapesApp.ViewModels
{
    public class DecksProgress : INotifyPropertyChanged
    {
        
        private ObservableCollection<ProgressFrame> sourceProgress { get; set; }
        private ObservableCollection<ProgressFrame> sourceProgress2 { get; set; }
        public ObservableCollection<ProgressFrame> sourceProgressAll { get; set; }

        public static readonly BindableProperty ProgressProperty = BindableProperty.CreateAttached("ProgressSource",
            typeof(ObservableCollection<ProgressFrame>),
            typeof(ProgressFrames), null);

        //public string ProgressSource
        //{
        //    get { return (ObservableCollection<ProgressFrame>)GetValue(ProgressProperty); }
        //    set { SetValue(ProgressProperty, value); }
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public DecksProgress() 
        {
            sourceProgress = new ObservableCollection<ProgressFrame>();
            CreateDecksCollection();
            sourceProgress2 = GetAllProgressFrames();

            sourceProgressAll = new ObservableCollection<ProgressFrame>(sourceProgress.Concat(sourceProgress2));
            
        }

        public static ObservableCollection<ProgressFrame> GetAllProgressFrames()
        {
            return new ObservableCollection<ProgressFrame>()
            {
                new ProgressFrame{FCDeckName = "-75 Deck", ProgressSign = "", ProgressPercentage = -75, DeckProgressColor = (Color)Application.Current.Resources["OxColorsRed"]},
                new ProgressFrame{FCDeckName = "-51 Deck", ProgressSign = "", ProgressPercentage = -51, DeckProgressColor = (Color)Application.Current.Resources["OxColorsRed"]},
                new ProgressFrame{FCDeckName = "-30 Deck", ProgressSign = "", ProgressPercentage = -30, DeckProgressColor = (Color)Application.Current.Resources["OxColorsBrightOrange"]},
                new ProgressFrame{FCDeckName = "-25 Deck", ProgressSign = "", ProgressPercentage = -25, DeckProgressColor = (Color)Application.Current.Resources["OxColorsYellow"]},
                new ProgressFrame{FCDeckName = "-10 Deck", ProgressSign = "", ProgressPercentage = -10, DeckProgressColor = (Color)Application.Current.Resources["OxColorsYellow"]},
                new ProgressFrame{FCDeckName = "10 Deck", ProgressSign = "+", ProgressPercentage = 10, DeckProgressColor = (Color)Application.Current.Resources["OxColorsGreen"]},
                new ProgressFrame{FCDeckName = "20 Deck", ProgressSign = "+", ProgressPercentage = 20, DeckProgressColor = (Color)Application.Current.Resources["OxColorsGreen"]},
                new ProgressFrame{FCDeckName = "40 Deck", ProgressSign = "+", ProgressPercentage = 40, DeckProgressColor = (Color)Application.Current.Resources["OxColorsGreen"]},
                new ProgressFrame{FCDeckName = "49 Deck", ProgressSign = "+", ProgressPercentage = 49, DeckProgressColor = (Color)Application.Current.Resources["OxColorsGreen"]},
                new ProgressFrame{FCDeckName = "56 Deck", ProgressSign = "+", ProgressPercentage = 56, DeckProgressColor = (Color)Application.Current.Resources["OxColorsViolet"]},
                new ProgressFrame{FCDeckName = "80 Deck", ProgressSign = "+", ProgressPercentage = 80, DeckProgressColor = (Color)Application.Current.Resources["OxColorsViolet"]},
                new ProgressFrame{FCDeckName = "90 Deck", ProgressSign = "+", ProgressPercentage = 90, DeckProgressColor = (Color)Application.Current.Resources["OxColorsViolet"]},
                new ProgressFrame{FCDeckName = "96 Deck", ProgressSign = "+", ProgressPercentage = 96, DeckProgressColor = (Color)Application.Current.Resources["OxColorsViolet"]},
            };
        }

        void CreateDecksCollection()
        {
            sourceProgress.Add(new ProgressFrame
            {
                FCDeckName = "Test Deck",
                ProgressPercentage = 20,
                DeckProgressColor = (Color)Application.Current.Resources["OxColorsGreen"],
                ProgressSign = "+",
            });
            sourceProgress.Add(new ProgressFrame
            {
                FCDeckName = "Another Deck",
                ProgressPercentage = 30,
                DeckProgressColor = (Color)Application.Current.Resources["OxColorsGreen"],
                ProgressSign = "+",
            });
            sourceProgress.Add(new ProgressFrame
            {
                FCDeckName = "Best Deck",
                ProgressPercentage = 89,
                DeckProgressColor = (Color)Application.Current.Resources["OxColorsViolet"],
                ProgressSign = "+",
            });
            sourceProgress.Add(new ProgressFrame
            {
                FCDeckName = "Worst Deck",
                ProgressPercentage = -75,
                DeckProgressColor = (Color)Application.Current.Resources["OxColorsRed"],
                ProgressSign = "",
            });
            sourceProgress.Add(new ProgressFrame
            {
                FCDeckName = "Last Deck",
                ProgressPercentage = 5,
                DeckProgressColor = (Color)Application.Current.Resources["OxColorsGreen"],
                ProgressSign = "+",
            });
            sourceProgress.Add(new ProgressFrame
            {
                FCDeckName = "Last Deck",
                ProgressPercentage = -10,
                DeckProgressColor = (Color)Application.Current.Resources["OxColorsYellow"],
                ProgressSign = "",
            });
        }

        //public event PropertyChangedEventHandler PropertyChanged;
        //private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
    }
}
