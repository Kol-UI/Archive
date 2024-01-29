using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ListView.Classes;
using ListView.Models;
using ListView.Views;
using Xamarin.Forms;

namespace ListView.Views
{
    public partial class AddMenu : INotifyPropertyChanged
    {
        //string exist = "*";
        //int count = 0;

        public AddMenu(ObservableCollection<noteItem> ItemsCollection)
        {
            InitializeComponent();

            ValidateB.Clicked += (o, e) =>
            {
                if (TitleEntry.Text == null)
                {
                    _ = AlertEmptyAsync();
                }
                else
                {
                    int a = ItemsCollection.Count() +1;
                    string newItem = TitleEntry.Text;
                    if (CheckWhitePng.IsVisible == false)
                    {
                        if (CheckPinkPng.IsVisible == true)
                        {
                            ItemsCollection.Insert(0, new noteItem() { ID = a, Name = newItem, ItemColor = (Color)Application.Current.Resources["AppColorsPink"] });
                        }
                        else if (CheckBluePng.IsVisible == true)
                        {
                            ItemsCollection.Insert(0, new noteItem() { ID = a, Name = newItem, ItemColor = (Color)Application.Current.Resources["AppColorsBlue"] });
                        }
                        else if (CheckBlueTurquoisePng.IsVisible == true)
                        {
                            ItemsCollection.Insert(0, new noteItem() { ID = a, Name = newItem, ItemColor = (Color)Application.Current.Resources["AppColorsBlueTurquoise"] });
                        }
                        else if (CheckVioletPng.IsVisible == true)
                        {
                            ItemsCollection.Insert(0, new noteItem() { ID = a, Name = newItem, ItemColor = (Color)Application.Current.Resources["AppColorsViolet"] });
                        }
                        else if (CheckPurplePng.IsVisible == true)
                        {
                            ItemsCollection.Insert(0, new noteItem() { ID = a, Name = newItem, ItemColor = (Color)Application.Current.Resources["AppColorsPurple"] });
                        }
                        else if (CheckStrawberryPng.IsVisible == true)
                        {
                            ItemsCollection.Insert(0, new noteItem() { ID = a, Name = newItem, ItemColor = (Color)Application.Current.Resources["AppColorsStrawberry"] });
                        }
                        else if (CheckRedPng.IsVisible == true)
                        {
                            ItemsCollection.Insert(0, new noteItem() { ID = a, Name = newItem, ItemColor = (Color)Application.Current.Resources["AppColorsRed"] });
                        }
                        else if (CheckOrangePng.IsVisible == true)
                        {
                            ItemsCollection.Insert(0, new noteItem() { ID = a, Name = newItem, ItemColor = (Color)Application.Current.Resources["AppColorsBrightOrange"] });
                        }
                        else if (CheckYellowPng.IsVisible == true)
                        {
                            ItemsCollection.Insert(0, new noteItem() { ID = a, Name = newItem, ItemColor = (Color)Application.Current.Resources["AppColorsYellow"] });
                        }
                        else if (CheckGreenPng.IsVisible == true)
                        {
                            ItemsCollection.Insert(0, new noteItem() { ID = a, Name = newItem, ItemColor = (Color)Application.Current.Resources["AppColorsGreen"] });
                        }
                        else if (CheckIceMintPng.IsVisible == true)
                        {
                            ItemsCollection.Insert(0, new noteItem() { ID = a, Name = newItem, ItemColor = (Color)Application.Current.Resources["AppColorsIceMint"] });
                        }
                        else if (CheckLilacPng.IsVisible == true)
                        {
                            ItemsCollection.Insert(0, new noteItem() { ID = a, Name = newItem, ItemColor = (Color)Application.Current.Resources["AppColorsLilac"] });
                        }
                        else
                        {
                            // Black
                            ItemsCollection.Insert(0, new noteItem() { ID = a, Name = newItem, ItemColor = (Color)Application.Current.Resources["AppColorsBlack"] });
                        }
                    }
                    else
                    {
                        // White
                        ItemsCollection.Insert(0, new noteItem() { ID = a, Name = newItem, ItemColor = (Color)Application.Current.Resources["AppColorsWhite"] });
                    }
                    Back();
                }
            };
        }

        void Button_Cancel(System.Object sender, System.EventArgs e)
        {
            Back();
        }

        void Back()
        {
            TitleEntry.Text = null;
            Navigation.PopModalAsync();
        }

        

        async Task AlertEmptyAsync()
        {
            await DisplayAlert ("Alert", "There is no item name, please enter one", "OK");
        }

        public async void PopModal()
        {
            await App.Current.MainPage.Navigation.PopModalAsync();
        }


        void ResetVisibility()
        {
            CheckPinkPng.IsVisible = false;
            CheckBluePng.IsVisible = false;
            CheckBlueTurquoisePng.IsVisible = false;
            CheckVioletPng.IsVisible = false;
            CheckPurplePng.IsVisible = false;
            CheckStrawberryPng.IsVisible = false;
            CheckRedPng.IsVisible = false;
            CheckOrangePng.IsVisible = false;
            CheckYellowPng.IsVisible = false;
            CheckGreenPng.IsVisible = false;
            CheckIceMintPng.IsVisible = false;
            CheckLilacPng.IsVisible = false;
            CheckWhitePng.IsVisible = false;
            CheckBlackPng.IsVisible = false;
        }

        void PinkTapped(System.Object sender, System.EventArgs e)
        {
            ResetVisibility();
            CheckPinkPng.IsVisible = true;
        }

        void BlueTapped(System.Object sender, System.EventArgs e)
        {
            ResetVisibility();
            CheckBluePng.IsVisible = true;
        }

        void BlueTurquoiseTapped(System.Object sender, System.EventArgs e)
        {
            ResetVisibility();
            CheckBlueTurquoisePng.IsVisible = true;
        }

        void VioletTapped(System.Object sender, System.EventArgs e)
        {
            ResetVisibility();
            CheckVioletPng.IsVisible = true;
        }

        void PurpleTapped(System.Object sender, System.EventArgs e)
        {
            ResetVisibility();
            CheckPurplePng.IsVisible = true;
        }

        void StrawberryTapped(System.Object sender, System.EventArgs e)
        {
            ResetVisibility();
            CheckStrawberryPng.IsVisible = true;
        }

        void RedTapped(System.Object sender, System.EventArgs e)
        {
            ResetVisibility();
            CheckRedPng.IsVisible = true;
        }

        void OrangeTapped(System.Object sender, System.EventArgs e)
        {
            ResetVisibility();
            CheckOrangePng.IsVisible = true;
        }

        void YellowTapped(System.Object sender, System.EventArgs e)
        {
            ResetVisibility();
            CheckYellowPng.IsVisible = true;
        }

        void GreenTapped(System.Object sender, System.EventArgs e)
        {
            ResetVisibility();
            CheckGreenPng.IsVisible = true;
        }

        void IceMintTapped(System.Object sender, System.EventArgs e)
        {
            ResetVisibility();
            CheckIceMintPng.IsVisible = true;
        }

        void LilacTapped(System.Object sender, System.EventArgs e)
        {
            ResetVisibility();
            CheckLilacPng.IsVisible = true;
        }

        void WhiteTapped(System.Object sender, System.EventArgs e)
        {
            ResetVisibility();
            CheckWhitePng.IsVisible = true;
        }

        void BlackTapped(System.Object sender, System.EventArgs e)
        {
            ResetVisibility();
            CheckBlackPng.IsVisible = true;
        }
    }
}