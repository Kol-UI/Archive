using System;
using System.ComponentModel;

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ListView.Models;
using ListView.Services;
using Xamarin.Forms;

namespace ListView.ViewModels
{
    public class DateTimeViewModel : INotifyPropertyChanged
    {
        DateTime dateTime = DateTime.Now;
        public event PropertyChangedEventHandler PropertyChanged;

        public DateTimeViewModel()
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(15), OnTimerTick);
        }
        bool OnTimerTick()
        {
            DateTime = DateTime.Now;
            return true;
        }
        public DateTime DateTime
        {
            private set
            {
                if (dateTime != value)
                {
                    dateTime = value;
                    // Fire the event.
                    //PropertyChangedEventHandler handler = PropertyChanged;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("DateTime"));
                    }
                }
            }
            get
            {
                return dateTime;
            }
        }
    }
}
