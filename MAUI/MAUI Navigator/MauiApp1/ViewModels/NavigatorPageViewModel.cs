using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MauiApp1.Classes;
using MauiApp1;
using MauiApp1.Services.Navigation;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public class NavigatorPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<ButtonItem> ButtonItems { get; set; } = new ObservableCollection<ButtonItem>();

        /*
        public NavigatorPageViewModel()
        {
            ButtonItems.Add(new ButtonItem
            {
                Text = "Open Grid Demo",
                Command = new Command(async () => await UseNavigator("Open Grid Demo"))
            });
        }

        public async Task UseNavigator(string pageToGo)
        {
            try
            {
                switch (pageToGo)
                {
                    case "Open Grid Demo":
                        await Shell.Current.GoToAsync("//NavigatorPage/GridDemoPage");
                        break;
                        // Add cases for other target pages as needed
                }
                //await Shell.Current.GoToAsync($"//NavigatorPage/GridDemoPage");
                //await Shell.Current.GoToAsync("//GridDemoPage");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Navigation error: {ex.Message}");
            }
        }
        */

        public NavigatorPageViewModel()
        {
            ButtonItems.Add(new ButtonItem
            {
                Text = "Open Grid Demo",
                Command = new Command(async () => await NavigateToGridDemoPage())
            });

            // Add more buttons for other views here
        }

        void Appearing()
        {
            try
            {
                ButtonItems.Add(new ButtonItem { Text = "Open Grid Demo", Command = new Command(async () => await NavigateToGridDemoPage()) });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        public async Task NavigateToGridDemoPage()
        {
            try
            {
                //await Navigation.PushAsync(new GridDemoPage());
                /*
                await Shell.Current.GoToAsync("//MainPage/NavigatorPage/GridDemoPage");
                await Shell.Current.GoToAsync("//GridDemoPage");
                await Shell.Current.GoToAsync("//MainPage/GridDemoPage");
                await Shell.Current.GoToAsync("//NavigatorPage/GridDemoPage");
                */
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Navigation error: {ex.Message}");
            }
        }


        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }
}