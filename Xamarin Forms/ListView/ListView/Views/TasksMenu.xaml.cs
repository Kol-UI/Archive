using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ListView.Models;
using ListView.Views;
using ListView;
using Xamanimation;

using Xamarin.Forms;

namespace ListView.Views
{
    public partial class TasksMenu : ContentPage
    {
        public static int StudyingPercentStats = 50;
        public static int ScanningPercentStats = 70;
        public static int AccountPercentStats = 86;
        public static int FolderSharingPercentStats = 40;

        public ObservableCollection<achievement> AchievementsStudying = new ObservableCollection<achievement>
            {
                new achievement { Text = "Study for the first time", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsBrightOrange"]},
                new achievement { Text = "Set study color to red", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsBrightOrange"]},
                new achievement { Text = "Set study color to yellow", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsBrightOrange"]},
                new achievement { Text = "Set study color to green", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsBrightOrange"]},
                new achievement { Text = "Study 3 times the same folder", Check = false, AchColor = (Color)Application.Current.Resources["AppColorsBrightOrange"]},
                new achievement { Text = "Study 3 times the same folder during one week", Check = false, AchColor = (Color)Application.Current.Resources["AppColorsBrightOrange"]},
                new achievement { Text = "Have at least 5 study folders set to green", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsBrightOrange"]},
                new achievement { Text = "Have at least 10 study folders set to green", Check = false, AchColor = (Color)Application.Current.Resources["AppColorsBrightOrange"]},
            };

        public ObservableCollection<achievement> AchievementsScanning = new ObservableCollection<achievement>
            {
                new achievement { Text = "First time", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsRed"]},
                new achievement { Text = "10 times", Check = false, AchColor = (Color)Application.Current.Resources["AppColorsRed"]},
                new achievement { Text = "20 times", Check = false, AchColor = (Color)Application.Current.Resources["AppColorsRed"]},
                new achievement { Text = "Note", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsRed"]},
                new achievement { Text = "FC", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsRed"]},
                new achievement { Text = "Agenda", Check = false, AchColor = (Color)Application.Current.Resources["AppColorsRed"]},
                new achievement { Text = "Book Page", Check = false, AchColor = (Color)Application.Current.Resources["AppColorsRed"]},
                new achievement { Text = "Memo", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsRed"]},
            };

        public ObservableCollection<achievement> AchievementsAccount = new ObservableCollection<achievement>
            {
                new achievement { Text = "Verify your email", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsBlue"]},
                new achievement { Text = "Upload a profile picture", Check = false, AchColor = (Color)Application.Current.Resources["AppColorsBlue"]},
                new achievement { Text = "Generate a QR Code", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsBlue"]},
                new achievement { Text = "Add a friend to your Contacts", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsBlue"]},
            };

        public ObservableCollection<achievement> AchievementsFolderSharing = new ObservableCollection<achievement>
            {
                new achievement { Text = "Create your first folder", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Set a color to a folder", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Change a color folder", Check = false, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Set a Black color to a folder", Check = false, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Set a White color to a folder", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Set a Lilac color to a folder", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Set a Violet color to a folder", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Set a Purple color to a folder", Check = false, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Set a Pink color to a folder", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Set a Strawberry color to a folder", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Set a Red color to a folder", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Set a Orange color to a folder", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Set a Yellow color to a folder", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Set a Green color to a folder", Check = false, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Set a Cyan color to a folder", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Set a Turquoise color to a folder", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Set a Blue color to a folder", Check = false, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Set a Green color to a folder", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Share a Note", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Share 5 Notes", Check = false, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Share a Folder", Check = true, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},
                new achievement { Text = "Share 5 Folders", Check = false, AchColor = (Color)Application.Current.Resources["AppColorsGreen"]},

            };


        public TasksMenu()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            StudyingPercent.Text = StudyingPercentStats + " %";
            ScanningPercent.Text = ScanningPercentStats + " %";
            AccountPercent.Text = AccountPercentStats + " %";
            FolderSharingPercent.Text = FolderSharingPercentStats + " %";
        }

        void TapGestureRecognizer_TappedStudying(System.Object sender, System.EventArgs e)
        {
            ResetBorders();
            FrameStudying.BorderColor = (Color)Application.Current.Resources["MainColor"];
            ScrollList.IsVisible = true;
            ScrollList.ItemsSource = AchievementsStudying;
        }

        void TapGestureRecognizer_TappedScanning(System.Object sender, System.EventArgs e)
        {
            ResetBorders();
            FrameScanning.BorderColor = (Color)Application.Current.Resources["MainColor"];
            ScrollList.IsVisible = true;
            ScrollList.ItemsSource = AchievementsScanning;
        }

        void TapGestureRecognizer_TappedAccount(System.Object sender, System.EventArgs e)
        {
            ResetBorders();
            FrameAccount.BorderColor = (Color)Application.Current.Resources["MainColor"];
            ScrollList.IsVisible = true;
            ScrollList.ItemsSource = AchievementsAccount;
        }

        void TapGestureRecognizer_TappedFolderSharing(System.Object sender, System.EventArgs e)
        {
            ResetBorders();
            FrameFolderSharing.BorderColor = (Color)Application.Current.Resources["MainColor"];
            ScrollList.IsVisible = true;
            ScrollList.ItemsSource = AchievementsFolderSharing;
        }

        void ResetBorders()
        {
            FrameStudying.BorderColor = Color.Transparent;
            FrameScanning.BorderColor = Color.Transparent;
            FrameAccount.BorderColor = Color.Transparent;
            FrameFolderSharing.BorderColor = Color.Transparent;
        }
    }
}
