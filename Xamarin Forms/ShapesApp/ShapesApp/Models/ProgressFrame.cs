using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace ShapesApp.Models
{
    public class ProgressFrame
    {
        public string FCDeckName { get; set; }
        public int ProgressPercentage { get; set; }
        public Color DeckProgressColor { get; set; }
        public string ProgressSign { get; set; }
    }
}
