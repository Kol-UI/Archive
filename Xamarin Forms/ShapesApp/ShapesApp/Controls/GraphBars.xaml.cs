using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShapesApp.ViewModels;
using Xamarin.Forms;

namespace ShapesApp.Controls
{
    public partial class GraphBars : ContentView
    {
        public GraphBars()
        {
            InitializeComponent();
            BindingContext = new GraphBarsViewModels();


            // Button 1
            var tapThisWeek = new TapGestureRecognizer();
            tapThisWeek.Tapped += async (s, e) =>
            {
                ThisWeekButton(s, e);
                var scaleUpAnimationTask = FrameButtonThisWeek.ScaleTo(0.9, 225);
                var fadeOutAnimationTask = FrameButtonThisWeek.FadeTo(0.5, 225);
                await Task.WhenAll(scaleUpAnimationTask, fadeOutAnimationTask);
                ThisWeekText.TextColor = (Color)Application.Current.Resources["ModernGray"];
                var scaleDownAnimationTask = FrameButtonThisWeek.ScaleTo(1, 225);
                var fadeInAnimationTask = FrameButtonThisWeek.FadeTo(1, 225);
                await Task.WhenAll(scaleDownAnimationTask, fadeInAnimationTask);
                ThisWeekText.TextColor = (Color)Application.Current.Resources["OxColorsWhite"];
            };


            // Button 2
            var tapPreviousWeek = new TapGestureRecognizer();
            tapPreviousWeek.Tapped += async (s, e) =>
            {
                PreviousWeekButton(s, e);
                var scaleUpAnimationTask = FrameButtonPreviousWeek.ScaleTo(0.9, 225);
                var fadeOutAnimationTask = FrameButtonPreviousWeek.FadeTo(0.5, 225);
                await Task.WhenAll(scaleUpAnimationTask, fadeOutAnimationTask);
                var scaleDownAnimationTask = FrameButtonPreviousWeek.ScaleTo(1, 225);
                var fadeInAnimationTask = FrameButtonPreviousWeek.FadeTo(1, 225);
                await Task.WhenAll(scaleDownAnimationTask, fadeInAnimationTask);
            };

            // Button 3
            var tapTwoWeeks = new TapGestureRecognizer();
            tapTwoWeeks.Tapped += async (s, e) =>
            {
                TwoWeeksAgoButton(s, e);
                var scaleUpAnimationTask = FrameButtonTwoWeeks.ScaleTo(0.9, 225);
                var fadeOutAnimationTask = FrameButtonTwoWeeks.FadeTo(0.5, 225);
                await Task.WhenAll(scaleUpAnimationTask, fadeOutAnimationTask);
                var scaleDownAnimationTask = FrameButtonTwoWeeks.ScaleTo(1, 225);
                var fadeInAnimationTask = FrameButtonTwoWeeks.FadeTo(1, 225);
                await Task.WhenAll(scaleDownAnimationTask, fadeInAnimationTask);
            };

            // Button 3
            var tapThreeWeeks = new TapGestureRecognizer();
            tapThreeWeeks.Tapped += async (s, e) =>
            {
                ThreeWeeksAgoButton(s, e);
                var scaleUpAnimationTask = FrameButtonThreeWeeks.ScaleTo(0.9, 225);
                var fadeOutAnimationTask = FrameButtonThreeWeeks.FadeTo(0.5, 225);
                await Task.WhenAll(scaleUpAnimationTask, fadeOutAnimationTask);
                var scaleDownAnimationTask = FrameButtonThreeWeeks.ScaleTo(1, 225);
                var fadeInAnimationTask = FrameButtonThreeWeeks.FadeTo(1, 225);
                await Task.WhenAll(scaleDownAnimationTask, fadeInAnimationTask);
            };



            FrameButtonThisWeek.GestureRecognizers.Add(tapThisWeek);
            FrameButtonPreviousWeek.GestureRecognizers.Add(tapPreviousWeek);
            FrameButtonTwoWeeks.GestureRecognizers.Add(tapTwoWeeks);
            FrameButtonThreeWeeks.GestureRecognizers.Add(tapThreeWeeks);
        }




        void ThisWeekButton(Object sender, EventArgs e)
        {
            HorizontalScrollView.ScrollToAsync(HorizontalScrollView, ScrollToPosition.Start, false);
        }

        void PreviousWeekButton(Object sender, EventArgs e)
        {
            HorizontalScrollView.ScrollToAsync(SecondaryFrameGraph, ScrollToPosition.Center, false);
        }

        void TwoWeeksAgoButton(Object sender, EventArgs e)
        {
            HorizontalScrollView.ScrollToAsync(ThirdFrameGraph, ScrollToPosition.Center, false);
        }

        void ThreeWeeksAgoButton(Object sender, EventArgs e)
        {
            HorizontalScrollView.ScrollToAsync(FourthFrameGraph, ScrollToPosition.Center, false);
        }
    }
}
