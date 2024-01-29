using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ListView.Classes;
using ListView.Models;
using Xamarin.Forms;
using System.ComponentModel;
using ListView.ViewModels;
using System.Collections;

namespace ListView.Views
{
    public partial class ListViewPage : INotifyPropertyChanged
    {
        string AddNew = "My New Item";

        public ObservableCollection<noteItem> ItemsCollection = new ObservableCollection<noteItem>
            {
                new noteItem { ID= 7, Name = "Red Folder", ItemColor = (Color)Application.Current.Resources["AppColorsRed"], SubFolderID = 30},
                new noteItem { ID= 6, Name = "Green Folder", ItemColor = (Color)Application.Current.Resources["AppColorsGreen"], SubFolderID = 31},
                new noteItem { ID= 5, Name = "Blue Folder", ItemColor = (Color)Application.Current.Resources["AppColorsBlue"], SubFolderID = 32},
                new noteItem { ID= 4, Name = "Yellow Folder", ItemColor = (Color)Application.Current.Resources["AppColorsYellow"], SubFolderID = 33},
                new noteItem { ID= 3, Name = "Orange Folder", ItemColor = (Color)Application.Current.Resources["AppColorsBrightOrange"], SubFolderID = 32},
                new noteItem { ID= 2, Name = "Purple Folder", ItemColor = (Color)Application.Current.Resources["AppColorsPurple"], SubFolderID = 33},
                new noteItem { ID= 1, Name = "Black Folder", ItemColor = (Color)Application.Current.Resources["AppColorsBlack"], SubFolderID = 99},
                new noteItem { ID= 25, Name = "Empty Test", ItemColor = (Color)Application.Current.Resources["AppColorsWhite"]},
            };

        public ObservableCollection<noteItem> SubFolder30 = new ObservableCollection<noteItem>
        {
            new noteItem { ID= 8, Name = "FlashCard 1", ItemColor = (Color)Application.Current.Resources["AppColorsYellow"]},
            new noteItem { ID= 9, Name = "FlashCard 2", ItemColor = (Color)Application.Current.Resources["AppColorsBrightOrange"]},
            new noteItem { ID= 10, Name = "FlashCard 3", ItemColor = (Color)Application.Current.Resources["AppColorsBlack"]},
        };

        public ObservableCollection<noteItem> SubFolder31 = new ObservableCollection<noteItem>
        {
            new noteItem { ID= 11, Name = "Note 1", ItemColor = (Color)Application.Current.Resources["AppColorsBlack"]},
            new noteItem { ID= 12, Name = "Note 2", ItemColor = (Color)Application.Current.Resources["AppColorsPurple"]},
            new noteItem { ID= 13, Name = "Note 3", ItemColor = (Color)Application.Current.Resources["AppColorsBlue"]},
            new noteItem { ID= 14, Name = "Note 4", ItemColor = (Color)Application.Current.Resources["AppColorsGreen"]},
            new noteItem { ID= 15, Name = "Note 5", ItemColor = (Color)Application.Current.Resources["AppColorsRed"]},
            new noteItem { ID= 16, Name = "Note 6", ItemColor = (Color)Application.Current.Resources["AppColorsGreen"]},
        };

        public ObservableCollection<noteItem> SubFolder32 = new ObservableCollection<noteItem>
        {
            new noteItem { ID= 17, Name = "Note 1", ItemColor = (Color)Application.Current.Resources["AppColorsBlack"]},
            new noteItem { ID= 18, Name = "Note 2", ItemColor = (Color)Application.Current.Resources["AppColorsPurple"]},
            new noteItem { ID= 19, Name = "Note 3", ItemColor = (Color)Application.Current.Resources["AppColorsBlue"]},
            new noteItem { ID= 20, Name = "Note 4", ItemColor = (Color)Application.Current.Resources["AppColorsGreen"]},
        };

        public ObservableCollection<noteItem> SubFolder33 = new ObservableCollection<noteItem>
        {
            new noteItem { ID= 21, Name = "FlashCard 1", ItemColor = (Color)Application.Current.Resources["AppColorsWhite"]},
            new noteItem { ID= 22, Name = "FlashCard 2", ItemColor = (Color)Application.Current.Resources["AppColorsViolet"]},
            new noteItem { ID= 23, Name = "FlashCard 3", ItemColor = (Color)Application.Current.Resources["AppColorsYellow"]},
        };


        public ObservableCollection<noteItem> content3 = new ObservableCollection<noteItem>
        {
            new noteItem { ID = 24, ItemColor = Color.Red, Name = "Red Test" },
        };

        public ObservableCollection<noteItem> Empty = new ObservableCollection<noteItem>
        {

        };

        public ListViewPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            listViewItems.ItemsSource = ItemsCollection;
        }


        public async void Delete(Object Sender, EventArgs args)
        {
            var action = await DisplayAlert("Deleting !", "Are you sure about deleting this item ?", "Yes", "No");
            if (action)
            {
                var btn = (Button)Sender;
                var todelete = (noteItem)btn?.CommandParameter;
                var vm = BindingContext as ListViewPage;
                vm.ItemsCollection.Remove(todelete);
            }
        }

        async void Share(Object Sender, EventArgs args)
        {
            var btn = (Button)Sender;
            var toshare = (noteItem)btn?.CommandParameter;

            string share = await DisplayActionSheet("Share: Send to?", "Cancel", null, "Contacts", "PDF", "Other");
            switch (share)
            {
                case "Contacts":
                    _ = Navigation.PushModalAsync(new ContentPageTest());
                    break;
                case "PDF":
                    await DisplayAlert("Alert", "You have been alerted", "OK");
                    break;
                case "Other":
                    await DisplayAlert("Alert", "You have been alerted", "OK");
                    break;
            }
        }

        private void ListView_ItemSelected(Object sender, SelectedItemChangedEventArgs e)
        {
            var list = (ListView)sender;
            list.SelectedItem = null;
        }

        public void Constructing()
        {
            for (int i = 0; i <= 100; i++)
            {
                string label = "";
                if (i % 3 == 0)
                    label += "Fizz";
                if (i % 5 == 0)
                    label += "Buzz";
                if (label.Length == 0)
                    label = i.ToString();
                Console.WriteLine(label);
                System.Threading.Thread.Sleep(500);
            }
        }


        async void Frame_Clicked_Add(System.Object sender, System.EventArgs e)
        {
            int a = ItemsCollection.Count() + 1;
            ItemsCollection.Insert(0, new noteItem() { ID = a, Name = AddNew, ItemColor = Color.White });

            var scaleUpAnimationTask = FrameAdd.ScaleTo(1.1, 225);
            var fadeOutAnimationTask = FrameAdd.FadeTo(0, 225);
            await Task.WhenAll(scaleUpAnimationTask, fadeOutAnimationTask);

            var scaleDownAnimationTask = FrameAdd.ScaleTo(1, 225);
            var fadeInAnimationTask = FrameAdd.FadeTo(1, 225);
            await Task.WhenAll(scaleDownAnimationTask, fadeInAnimationTask);
        }

        async void Frame_AddMenu(System.Object sender, System.EventArgs e)
        {
            var scaleUpAnimationTask = FrameCenter.ScaleTo(1.3, 225);
            var fadeOutAnimationTask = FrameCenter.FadeTo(0, 225);
            await Task.WhenAll(scaleUpAnimationTask, fadeOutAnimationTask);

            var scaleDownAnimationTask = FrameCenter.ScaleTo(1, 225);
            var fadeInAnimationTask = FrameCenter.FadeTo(1, 225);
            await Task.WhenAll(scaleDownAnimationTask, fadeInAnimationTask);

            _ = Navigation.PushModalAsync(new AddMenu(ItemsCollection));
        }


        async void ClearAll(System.Object sender, System.EventArgs e)
        {
            var scaleUpAnimationTask = FrameClear.ScaleTo(1.1, 225);
            var fadeOutAnimationTask = FrameClear.FadeTo(0, 225);
            await Task.WhenAll(scaleUpAnimationTask, fadeOutAnimationTask);

            var scaleDownAnimationTask = FrameClear.ScaleTo(1, 225);
            var fadeInAnimationTask = FrameClear.FadeTo(1, 225);
            await Task.WhenAll(scaleDownAnimationTask, fadeInAnimationTask);

            var action = await DisplayAlert("Deleting !", "Are you sure about deleting everything ?", "Yes", "No");
            if (action)
            {
                var action2 = await DisplayAlert("Deleting !", "Really sure ?", "Yes", "No");
                if (action2)
                {
                    ItemsCollection.Clear();
                }
            }
        }

        async void ListViewItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            Console.WriteLine("Item Selected");

            //var content = e.Item as noteItem;
            //var content = new noteItem { ID = 21, ItemColor = Color.Red, Name = "Test" };
            //await Navigation.PushAsync(new ListViewPage(content));
            var item = (noteItem)e.Item;

            switch (item.SubFolderID) // Inside Case 30
            {
                case 30:
                    await Navigation.PushAsync(new ListViewPageFolder(SubFolder30));
                    break;
                case 31:
                    await Navigation.PushAsync(new ListViewPageFolder(SubFolder31));
                    break;
                case 32:
                    await Navigation.PushAsync(new ListViewPageFolder(SubFolder32));
                    break;
                case 33:
                    await Navigation.PushAsync(new ListViewPageFolder(SubFolder33));
                    break;
                case 99:
                    await Navigation.PushAsync(new ListViewPageFolder(content3));
                    break;
                default:
                    await Navigation.PushAsync(new ListViewPageFolder(Empty));
                    break;
            };

            //_ = Navigation.PushModalAsync(new AddMenu(ItemsCollection));
            //var PagePlus = string NewPageItemsString = "b";
            //var NewPageItems = new ObservableCollection<noteItem> 
            //{
            //    new noteItem { ID = 8, Name = "Yellow", ItemColor = (Color)Application.Current.Resources["AppColorsYellow"] },
            //};
            //await Navigation.PushAsync(new ListViewPage());

            //var NewPageItems = new ObservableCollection<noteItem>
            //{
            //    new noteItem { ID = 8, Name = "YellowTest", ItemColor = (Color)Application.Current.Resources["AppColorsYellow"] },
            //};

            //var OtherListPage = new ListViewPage();
            //OtherListPage.BindingContext = NewPageItemsString = "b";
            //await Navigation.PushAsync(OtherListPage);

            //OtherListPage.BindingContext = NewPageItems;
        }
    }
}
