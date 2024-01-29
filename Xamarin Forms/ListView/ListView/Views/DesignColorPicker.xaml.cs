using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListView.Views
{
    public partial class DesignColorPicker : ContentPage
    {
        public DesignColorPicker()
        {
            InitializeComponent();
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
