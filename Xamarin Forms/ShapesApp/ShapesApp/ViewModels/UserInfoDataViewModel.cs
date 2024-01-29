using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ShapesApp.Models;
using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
namespace ShapesApp.ViewModels
{
    public class UserInfoDataViewModel : INotifyPropertyChanged
    {

        private UserInfoDataModel userInfoDataModel;


        public UserInfoDataViewModel()
        {
            userInfoDataModel = new UserInfoDataModel
            {
                // Stats Frame
                CompletedLearning = 12,
                CurrentlyLearning = 9,
                BestStreak = 86,
                LearningStartDate = new DateTime(2021, 04, 15).ToString("MM/dd/yyyy"),
                // Features Frame
                StudyModeActivated = 16,
                TimePastStudying = 45,
                RemindersCurrentlyActive = 3,
                // Share & Contacts Frame
                ContactsCount = 8,
                ElementsReceived = 15,
                ElementsShared = 14,
                // Stored Files Frame
                TotalStockedFiles = 560,
                TotalPagesStored = 4076,
                DecksCount = 21,
                NotesStocked = 154,
                IndexCardsStocked = 23,
                FlashCardsStocked = 375,
                MemosStocked = 3,
                UnfiledFiles = 5,
                FilesInTrash = 7,
                // Scan & Photo Frame
                TotalScannedFiles = 5932,
                NotesScanned = 253,
                IndexCardsScanned = 24,
                FlashCardsScanned = 5645,
                MemosScanned = 10,
                ExternalImagesAdded = 19,
                // Profile & Security Frame
                ProfileType = true,
                ScLiked = true,
                SecondaryEmailSet = true,

            };
        }


        public int CompletedLearning
        {
            get { return userInfoDataModel.CompletedLearning; }
            set
            {
                if (userInfoDataModel.CompletedLearning != value)
                {
                    userInfoDataModel.CompletedLearning = value;
                    OnPropertyChange("CompletedLearning");
                }
            }
        }

        public int CurrentlyLearning
        {
            get { return userInfoDataModel.CurrentlyLearning; }
            set
            {
                if (userInfoDataModel.CurrentlyLearning != value)
                {
                    userInfoDataModel.CurrentlyLearning = value;
                    OnPropertyChange("CurrentlyLearning");
                }
            }
        }

        public int BestStreak
        {
            get { return userInfoDataModel.BestStreak; }
            set
            {
                if (userInfoDataModel.BestStreak != value)
                {
                    userInfoDataModel.BestStreak = value;
                    OnPropertyChange("BestStreak");
                }
            }
        }

        public string LearningStartDate
        {
            get { return userInfoDataModel.LearningStartDate; }
            set
            {
                if (userInfoDataModel.LearningStartDate != value)
                {
                    userInfoDataModel.LearningStartDate = value;
                    OnPropertyChange("LearningStartDate");
                }
            }
        }

        public int StudyModeActivated
        {
            get { return userInfoDataModel.StudyModeActivated; }
            set
            {
                if (userInfoDataModel.StudyModeActivated != value)
                {
                    userInfoDataModel.StudyModeActivated = value;
                    OnPropertyChange("StudyModeActivated");
                }
            }
        }
        
        public int TimePastStudying
        {
            get { return userInfoDataModel.TimePastStudying; }
            set
            {
                if (userInfoDataModel.TimePastStudying != value)
                {
                    userInfoDataModel.TimePastStudying = value;
                    OnPropertyChange("TimePastStudying");
                }
            }
        }

        public int RemindersCurrentlyActive
        {
            get { return userInfoDataModel.RemindersCurrentlyActive; }
            set
            {
                if (userInfoDataModel.RemindersCurrentlyActive != value)
                {
                    userInfoDataModel.RemindersCurrentlyActive = value;
                    OnPropertyChange("RemindersCurrentlyActive");
                }
            }
        }

        public int ContactsCount
        {
            get { return userInfoDataModel.ContactsCount; }
            set
            {
                if (userInfoDataModel.ContactsCount != value)
                {
                    userInfoDataModel.ContactsCount = value;
                    OnPropertyChange("ContactsCount");
                }
            }
        }

        public int ElementsReceived
        {
            get { return userInfoDataModel.ElementsReceived; }
            set
            {
                if (userInfoDataModel.ElementsReceived != value)
                {
                    userInfoDataModel.ElementsReceived = value;
                    OnPropertyChange("ElementsReceived");
                }
            }
        }

        public int ElementsShared
        {
            get { return userInfoDataModel.ElementsShared; }
            set
            {
                if (userInfoDataModel.ElementsShared != value)
                {
                    userInfoDataModel.ElementsShared = value;
                    OnPropertyChange("ElementsShared");
                }
            }
        }

        public int TotalStockedFiles
        {
            get { return userInfoDataModel.TotalStockedFiles; }
            set
            {
                if (userInfoDataModel.TotalStockedFiles != value)
                {
                    userInfoDataModel.TotalStockedFiles = value;
                    OnPropertyChange("TotalStockedFiles");
                }
            }
        }

        public int TotalPagesStored
        {
            get { return userInfoDataModel.TotalPagesStored; }
            set
            {
                if (userInfoDataModel.TotalPagesStored != value)
                {
                    userInfoDataModel.TotalPagesStored = value;
                    OnPropertyChange("TotalPagesStored");
                }
            }
        }

        public int DecksCount
        {
            get { return userInfoDataModel.DecksCount; }
            set
            {
                if (userInfoDataModel.DecksCount != value)
                {
                    userInfoDataModel.DecksCount = value;
                    OnPropertyChange("DecksCount");
                }
            }
        }

        public int NotesStocked
        {
            get { return userInfoDataModel.NotesStocked; }
            set
            {
                if (userInfoDataModel.NotesStocked != value)
                {
                    userInfoDataModel.NotesStocked = value;
                    OnPropertyChange("NotesStocked");
                }
            }
        }

        public int IndexCardsStocked
        {
            get { return userInfoDataModel.IndexCardsStocked; }
            set
            {
                if (userInfoDataModel.IndexCardsStocked != value)
                {
                    userInfoDataModel.IndexCardsStocked = value;
                    OnPropertyChange("IndexCardsStocked");
                }
            }
        }

        public int FlashCardsStocked
        {
            get { return userInfoDataModel.FlashCardsStocked; }
            set
            {
                if (userInfoDataModel.FlashCardsStocked != value)
                {
                    userInfoDataModel.FlashCardsStocked = value;
                    OnPropertyChange("FlashCardsStocked");
                }
            }
        }
        
        public int MemosStocked
        {
            get { return userInfoDataModel.MemosStocked; }
            set
            {
                if (userInfoDataModel.MemosStocked != value)
                {
                    userInfoDataModel.MemosStocked = value;
                    OnPropertyChange("MemosStocked");
                }
            }
        }

        public int UnfiledFiles
        {
            get { return userInfoDataModel.UnfiledFiles; }
            set
            {
                if (userInfoDataModel.UnfiledFiles != value)
                {
                    userInfoDataModel.UnfiledFiles = value;
                    OnPropertyChange("UnfiledFiles");
                }
            }
        }

        public int FilesInTrash
        {
            get { return userInfoDataModel.FilesInTrash; }
            set
            {
                if (userInfoDataModel.FilesInTrash != value)
                {
                    userInfoDataModel.FilesInTrash = value;
                    OnPropertyChange("FilesInTrash");
                }
            }
        }

        public int TotalScannedFiles
        {
            get { return userInfoDataModel.TotalScannedFiles; }
            set
            {
                if (userInfoDataModel.TotalScannedFiles != value)
                {
                    userInfoDataModel.TotalScannedFiles = value;
                    OnPropertyChange("TotalScannedFiles");
                }
            }
        }

        public int NotesScanned
        {
            get { return userInfoDataModel.NotesScanned; }
            set
            {
                if (userInfoDataModel.NotesScanned != value)
                {
                    userInfoDataModel.NotesScanned = value;
                    OnPropertyChange("NotesScanned");
                }
            }
        }

        public int IndexCardsScanned
        {
            get { return userInfoDataModel.IndexCardsScanned; }
            set
            {
                if (userInfoDataModel.IndexCardsScanned != value)
                {
                    userInfoDataModel.IndexCardsScanned = value;
                    OnPropertyChange("IndexCardsScanned");
                }
            }
        }

        public int FlashCardsScanned
        {
            get { return userInfoDataModel.FlashCardsScanned; }
            set
            {
                if (userInfoDataModel.FlashCardsScanned != value)
                {
                    userInfoDataModel.FlashCardsScanned = value;
                    OnPropertyChange("FlashCardsScanned");
                }
            }
        }

        public int MemosScanned
        {
            get { return userInfoDataModel.MemosScanned; }
            set
            {
                if (userInfoDataModel.MemosScanned != value)
                {
                    userInfoDataModel.MemosScanned = value;
                    OnPropertyChange("MemosScanned");
                }
            }
        }

        public int ExternalImagesAdded
        {
            get { return userInfoDataModel.ExternalImagesAdded; }
            set
            {
                if (userInfoDataModel.ExternalImagesAdded != value)
                {
                    userInfoDataModel.ExternalImagesAdded = value;
                    OnPropertyChange("ExternalImagesAdded");
                }
            }
        }

        public bool ProfileType
        {
            get { return userInfoDataModel.ProfileType; }
            set
            {
                if (userInfoDataModel.ProfileType != value)
                {
                    userInfoDataModel.ProfileType = value;
                    OnPropertyChange("ProfileType");
                }
            }
        }

        public bool ScLiked
        {
            get { return userInfoDataModel.ScLiked; }
            set
            {
                if (userInfoDataModel.ScLiked != value)
                {
                    userInfoDataModel.ScLiked = value;
                    OnPropertyChange("ScLiked");
                }
            }
        }

        public bool SecondaryEmailSet
        {
            get { return userInfoDataModel.SecondaryEmailSet; }
            set
            {
                if (userInfoDataModel.SecondaryEmailSet != value)
                {
                    userInfoDataModel.SecondaryEmailSet = value;
                    OnPropertyChange("SecondaryEmailSet");
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
