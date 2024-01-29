using System;
using System.ComponentModel;
using ShapesApp.Models;

namespace ShapesApp.ViewModels
{
    public class InfoStatsViewModel : INotifyPropertyChanged
    {
        private InfoStatsModel infoStatsModel;
        public InfoStatsViewModel()
        {
            infoStatsModel = new InfoStatsModel()
            {
                ReviewCount = 4,
                StreakCount = 75,
            };
        }

        public int ReviewCount
        {
            get { return infoStatsModel.ReviewCount; }
            set
            {
                if (infoStatsModel.ReviewCount != value)
                {
                    infoStatsModel.ReviewCount = value;
                    OnPropertyChange("ReviewCount");
                }
            }
        }

        public int StreakCount
        {
            get { return infoStatsModel.StreakCount; }
            set
            {
                if (infoStatsModel.StreakCount != value)
                {
                    infoStatsModel.StreakCount = value;
                    OnPropertyChange("StreakCount");
                }
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
