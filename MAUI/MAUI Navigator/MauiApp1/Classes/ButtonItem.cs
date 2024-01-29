using System;
using System.Windows.Input;

namespace MauiApp1.Classes
{
    public class ButtonItem
    {
        public string Text { get; set; }
        public NavigationCategory Category { get; set; }
        public ICommand Command { get; set; }
    }
}