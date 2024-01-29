using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
namespace ShapesApp.Models
{
    public class UserInfoDataModel
    {
        // Stats Frame
        public int CompletedLearning { get; set; }
        public int CurrentlyLearning { get; set; }
        public int BestStreak { get; set; }
        public string LearningStartDate { get; set; }

        // Features Frame
        public int StudyModeActivated { get; set; }
        public int TimePastStudying { get; set; }
        public int RemindersCurrentlyActive { get; set; }

        // Share & Contacts Frame
        public int ContactsCount { get; set; }
        public int ElementsReceived { get; set; }
        public int ElementsShared { get; set; }

        // Current Stockage Frame
        public int TotalStockedFiles { get; set; }
        public int TotalPagesStored { get; set; }
        public int DecksCount { get; set; }
        public int NotesStocked { get; set; }
        public int IndexCardsStocked { get; set; }
        public int FlashCardsStocked { get; set; }
        public int MemosStocked { get; set; }
        public int FilesInTrash { get; set; }
        public int UnfiledFiles { get; set; }

        // Scan & Photo Frame
        public int TotalScannedFiles { get; set; }
        public int NotesScanned { get; set; }
        public int IndexCardsScanned { get; set; }
        public int FlashCardsScanned { get; set; }
        public int MemosScanned { get; set; }
        public int ExternalImagesAdded { get; set; }

        // Profile & Security Frame
        public bool ProfileType { get; set; }
        public bool ScLiked { get; set; }
        public bool SecondaryEmailSet { get; set; }

    }
}

