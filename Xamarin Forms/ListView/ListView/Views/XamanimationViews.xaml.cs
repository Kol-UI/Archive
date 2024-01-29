using System;
using System.Collections.Generic;
using Xamanimation;

using Xamarin.Forms;

namespace ListView.Views
{
    public partial class XamanimationViews : ContentPage
    {
        public XamanimationViews()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //AnimationBox.Animate(new HeartAnimation());
            //FadeBox.Animate(new FadeToAnimation());
            //FadeBox.Animate(new FadeOutAnimation());
            //FadeBox2.Animate(new FadeToAnimation());
            //FadeBox3.Animate(new FadeOutAnimation());
            //ButtonXamanimation.Animate(new FadeToAnimation());
            //ButtonXamanimation.Animate(new FadeOutAnimation());
            ButtonXamanimation.Animate(new HeartAnimation());
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            ButtonXamanimation.Animate(new JumpAnimation());
            FadeBox.Animate(new FadeToAnimation()); // Is Visible False
            FadeBox2.Animate(new FadeOutAnimation());
            FadeBox3.Animate(new FadeOutAnimation());
        }

        void Button_Clicked2(System.Object sender, System.EventArgs e)
        {
            ButtonXamanimation2.Animate(new JumpAnimation());
            FadeBox2.Animate(new FadeInAnimation());
            FadeBox3.Animate(new FadeInAnimation());
        }

        async void Button_Clicked3(System.Object sender, System.EventArgs e)
        {
            _ = ButtonXamanimationNextView.Animate(new JumpAnimation());
            await Navigation.PushAsync(new XamanimationChart());
        }
    }
}
