using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microcharts;
using Microcharts.Forms;
using SkiaSharp;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ListView.Classes;
using ListView.Models;
using ListView.ViewModels;
using System.Collections;
using Entry = Microcharts.ChartEntry;
using Xamarin.Essentials;

namespace ListView.Views
{
    public partial class MicroChartsView : ContentPage
    {
        
        // Not studied data
        public static float a = 4;
        public static string aString = a.ToString();
        public static string aLabel = "Not studied";
        // Not mastered data
        public static float b = 14;
        public static string bString = b.ToString();
        public static string bLabel = "Not mastered";
        // In progress data
        public static float c = 29;
        public static string cString = c.ToString();
        public static string cLabel = "In progress";
        // Done data
        public static float d = 75;
        public static string dString = d.ToString();
        public static string dLabel = "Done";

        // Week reviews
        public static float ThisWeek = 4;
        public static string ThisWeekString = ThisWeek.ToString();
        public static string ThisWeekLabel = "This Week";

        public static float LastWeek = 18;
        public static string LastWeekString = LastWeek.ToString();
        public static string LastWeekLabel = "Last Week";

        public static float TwoWeeksAgo = 6;
        public static string TwoWeeksAgoString = TwoWeeksAgo.ToString();
        public static string TwoWeeksAgoLabel = "2 Weeks ago";

        public static float ThreeWeeksAgo = 3;
        public static string ThreeWeeksAgoString = ThreeWeeksAgo.ToString();
        public static string ThreeWeeksAgoLabel = "3 Weeks ago";

        public static float FourWeeksAgo = 10;
        public static string FourWeeksAgoString = FourWeeksAgo.ToString();
        public static string FourWeeksAgoLabel = "4 Weeks ago";

        public static float LastMonth = 38;
        public static string LastMonthString = LastMonth.ToString();
        public static string LastMonthLabel = "Last Month";


        List<Entry> entries = new List<Entry>
        {
            new Entry(2)
            {
                Color =  SKColor.Parse("#00CED1"),
                Label = "test 1",
                ValueLabel = "2",
                ValueLabelColor = SKColor.Parse("#00CED1"),
            },
            new Entry(30)
            {
                Color =  SKColor.Parse("#F9F871"),
                Label = "test 2",
                ValueLabel = "30",
                ValueLabelColor = SKColor.Parse("#F9F871"),
            },
            new Entry(75)
            {
                Color =  SKColor.Parse("#E479C8"),
                Label = "test 3",
                ValueLabel = "75",
                ValueLabelColor = SKColor.Parse("#E479C8"),
            },
            new Entry(56)
            {
                Color =  SKColor.Parse("#94F7B2"),
                Label = "test 4",
                ValueLabel = "56",
                ValueLabelColor = SKColor.Parse("#94F7B2"),
            },
        };

        List<Entry> daylies = new List<Entry>
        {
            // Not studied data
            new Entry(a)
            {
                Color =  SKColor.Parse("#615D59"),
                Label = aLabel,
                ValueLabel = aString,
                ValueLabelColor = SKColor.Parse("#615D59"),
            },
            // Not mastered data
            new Entry(b)
            {
                Color =  SKColor.Parse("#F95E62"),
                Label = bLabel,
                ValueLabel = bString,
                ValueLabelColor = SKColor.Parse("#F95E62"),
            },
            // In progress data
            new Entry(c)
            {
                Color =  SKColor.Parse("#FFF166"),
                Label = cLabel,
                ValueLabel = cString,
                ValueLabelColor = SKColor.Parse("#FFF166"),
            },
            // Done data
            new Entry(d)
            {
                Color =  SKColor.Parse("#73C92D"),
                Label = dLabel,
                ValueLabel = dString,
                ValueLabelColor = SKColor.Parse("#73C92D"),
            },
        };

        List<Entry> weeks = new List<Entry>
        {
            new Entry(LastMonth)
            {
                Color =  SKColor.Parse("#28008C"),
                Label = LastMonthLabel,
                ValueLabel = LastMonthString,
                ValueLabelColor = SKColor.Parse("#28008C"),
            },
            new Entry(FourWeeksAgo)
            {
                Color =  SKColor.Parse("#0074A2"),
                Label = FourWeeksAgoLabel,
                ValueLabel = FourWeeksAgoString,
                ValueLabelColor = SKColor.Parse("#0074A2"),
            },
            new Entry(ThreeWeeksAgo)
            {
                Color =  SKColor.Parse("#0074A2"),
                Label = ThreeWeeksAgoLabel,
                ValueLabel = ThreeWeeksAgoString,
                ValueLabelColor = SKColor.Parse("#0074A2"),
            },
            new Entry(TwoWeeksAgo)
            {
                Color =  SKColor.Parse("#6A9DE0"),
                Label = TwoWeeksAgoLabel,
                ValueLabel = TwoWeeksAgoString,
                ValueLabelColor = SKColor.Parse("#6A9DE0"),
            },
            new Entry(LastWeek)
            {
                Color =  SKColor.Parse("#4CB4E7"),
                Label = LastWeekLabel,
                ValueLabel = LastWeekString,
                ValueLabelColor = SKColor.Parse("#4CB4E7"),
            },
            new Entry(ThisWeek)
            {
                Color =  SKColor.Parse("#00CFBB"),
                Label = ThisWeekLabel,
                ValueLabel = ThisWeekString,
                ValueLabelColor = SKColor.Parse("#00CFBB"),
            },
        };

        public MicroChartsView()
        {
            InitializeComponent();

            DayliesChart1.Chart = new DonutChart() { Entries = daylies, LabelTextSize = 22f, BackgroundColor = SKColors.Transparent };
            WeekChart.Chart = new LineChart()
            {
                Entries = weeks,
                LabelTextSize = 22f,
                LineMode = LineMode.Straight,
                PointMode = PointMode.Square,
                LineSize = 10f,
                PointSize = 20,
                BackgroundColor = SKColors.Transparent,
                ValueLabelOrientation = Orientation.Horizontal,
            };

            Chart1.Chart = new RadialGaugeChart() { Entries = daylies, LabelTextSize = 22f, LineSize = 30f, BackgroundColor = SKColors.Transparent };
            Chart2.Chart = new LineChart() { Entries = entries, LabelTextSize = 45f, BackgroundColor = SKColors.Transparent };
            Chart3.Chart = new DonutChart() { Entries = entries, LabelTextSize = 45f, BackgroundColor = SKColors.Transparent };
            Chart4.Chart = new BarChart() { Entries = entries, LabelTextSize = 45f, BackgroundColor = SKColors.Transparent };
            Chart5.Chart = new PointChart() { Entries = entries, LabelTextSize = 45f, BackgroundColor = SKColors.Transparent };
            Chart6.Chart = new RadarChart() { Entries = entries, LabelTextSize = 55f, BackgroundColor = SKColors.Transparent };
            Chart7.Chart = new LineChart() { Entries = entries, LabelTextSize = 45f, LineSize = 32f, BackgroundColor = SKColors.Transparent };
            Chart8.Chart = new RadialGaugeChart() { Entries = entries, LabelTextSize = 45f, LineSize = 40f, BackgroundColor = SKColors.Transparent };
  
        }

        async void HowToStudyFrame(System.Object sender, System.EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("https://learn.microsoft.com/en-us/xamarin/xamarin-forms/"));
        }

        async void MoreTipsFrame(System.Object sender, System.EventArgs e)
        {
            await Launcher.OpenAsync(new Uri("https://learn.microsoft.com/en-us/xamarin/xamarin-forms/"));
        }

        async void GetGlobalStats(System.Object sender, System.EventArgs e)
        {

            
            await Navigation.PushAsync(new GlobalStatsView());
            // await Shell.Current.Navigation.PopToRootAsync();
        }
    }
}