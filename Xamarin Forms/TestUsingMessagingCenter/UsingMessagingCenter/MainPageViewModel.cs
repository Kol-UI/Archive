using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace UsingMessagingCenter
{
    public class MainPageViewModel
    {
        public ObservableCollection<string> Greetings { get; set; }

        public MainPageViewModel()
        {
            Greetings = new ObservableCollection<string>();

            MessagingCenter.Subscribe<MainPage>(this, "Hi", (sender) =>
            {
                Greetings.Add("Hi");
            });

            MessagingCenter.Subscribe<MainPage>(this, "Count", (sender) =>
            {
                var number = Greetings.Count();
                string countMessage = "Number of items: " + number.ToString();
                Greetings.Add(countMessage);
            });

            MessagingCenter.Subscribe<MainPage>(this, "DeleteFirst", (sender) =>
            {
                if (Greetings.Count != 0)
                {
                    Greetings.RemoveAt(0);
                }
            });

            MessagingCenter.Subscribe<MainPage>(this, "Clear", (sender) =>
            {
                if (Greetings.Count != 0)
                {
                    Greetings.Clear();
                }
            });

            MessagingCenter.Subscribe<MainPage, string>(this, "Hi", (sender, arg) =>
            {
                Greetings.Add("Hi " + arg);
            });

            MessagingCenter.Subscribe<MainPage>(this, "Time", (sender) =>
            {
                var time = DateTime.Now.ToString();
                Greetings.Add("Message Received at " + time);
            });
        }
    }
}

