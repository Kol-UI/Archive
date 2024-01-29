using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Microcharts;
using Microcharts.Forms;
using ListView;
using SkiaSharp;
using Xamarin.Forms;
using Entry = Microcharts.ChartEntry;


namespace ListView.Views
{
    public partial class GlobalStatsView : ContentPage
    {
        // Shared - Created - Scanned Chart
        public static float FoldersShared = 13;
        public static string FoldersSharedString = FoldersShared.ToString();
        public static string FoldersSharedLabel = "Folders Shared";
        public static float FoldersCreated = 76;
        public static string FoldersCreatedString = FoldersCreated.ToString();
        public static string FoldersCreatedLabel = "Folders Created";
        public static float TotalScan = 863;
        public static string TotalScanString = TotalScan.ToString();
        public static string TotalScanLabel = "Scans Total";

        //public static string TestColorToString = (Color)Application.Current.Resources["AppColorsRed"].ToString();
        //public static SKColor TestColor = SKColor.TryParse((Color)Application.Current.Resources["AppColorsRed"], out SkiaSharp.SKColor testcolor);


        List<Entry> BarChartEntries = new List<Entry>
        {
            new Entry(FoldersShared)
            {
                Color = SKColor.Parse("#00C9A7"),
                Label = FoldersSharedLabel,
                ValueLabel = FoldersSharedString,
                ValueLabelColor = SKColor.Parse("#00C9A7"),
            },
            new Entry(FoldersCreated)
            {
                Color = SKColor.Parse("#0088C2"),
                Label = FoldersCreatedLabel,
                ValueLabel = FoldersCreatedString,
                ValueLabelColor = SKColor.Parse("#0088C2"),
            },
            new Entry(TotalScan)
            {
                Color = SKColor.Parse("#FF878C"),
                Label = TotalScanLabel,
                ValueLabel = TotalScanString,
                ValueLabelColor = SKColor.Parse("#FF878C"),
            }
        };

        // Document Type Chart
        public static float MemosCount = 7;
        public static float NotesCount = 47;
        public static float FCCount = 82;
        public static float BoardsCount = 2;
        public static float PageBooksCount = 19;
        public static float AgendasCount = 25;
        public static float OthersCount = 12;

        public static string MemosCountString = MemosCount.ToString();
        public static string MemosCountLabel = "Memos";
        public static string NotesCountString = NotesCount.ToString();
        public static string NotesCountLabel = "Notes";
        public static string FCCountString = FCCount.ToString();
        public static string FCCountLabel = "FC";
        public static string BoardsCountString = BoardsCount.ToString();
        public static string BoardsCountLabel = "Boards";
        public static string PageBooksCountString = PageBooksCount.ToString();
        public static string PageBooksCountLabel = "Page Books";
        public static string AgendasCountString = AgendasCount.ToString();
        public static string AgendasCountLabel = "Agendas";
        public static string OthersCountString = OthersCount.ToString();
        public static string OthersCountLabel = "Others";

        List<Entry> DocumentTypeEntries = new List<Entry>
        {
            new Entry(MemosCount)
            {
                Color = SKColor.Parse("#00CFBB"),
                Label = MemosCountLabel,
                ValueLabel = MemosCountString,
                ValueLabelColor = SKColor.Parse("#00CFBB"),
            },
            new Entry(AgendasCount)
            {
                Color = SKColor.Parse("#73C92D"),
                Label = AgendasCountLabel,
                ValueLabel = AgendasCountString,
                ValueLabelColor = SKColor.Parse("#73C92D"),
            },
            new Entry(OthersCount)
            {
                Color = SKColor.Parse("#0074A2"),
                Label = OthersCountLabel,
                ValueLabel = OthersCountString,
                ValueLabelColor = SKColor.Parse("#0074A2"),
            },
            new Entry(BoardsCount)
            {
                Color = SKColor.Parse("#A288D9"),
                Label = BoardsCountLabel,
                ValueLabel = BoardsCountString,
                ValueLabelColor = SKColor.Parse("#A288D9"),
            },
            new Entry(PageBooksCount)
            {
                Color = SKColor.Parse("#FF883E"),
                Label = PageBooksCountLabel,
                ValueLabel = PageBooksCountString,
                ValueLabelColor = SKColor.Parse("#FF883E"),
            },
            new Entry(NotesCount)
            {
                Color = SKColor.Parse("#28008C"),
                Label = NotesCountLabel,
                ValueLabel = NotesCountString,
                ValueLabelColor = SKColor.Parse("#28008C"),
            },
            new Entry(FCCount)
            {
                Color = SKColor.Parse("#F95E62"),
                Label = FCCountLabel,
                ValueLabel = FCCountString,
                ValueLabelColor = SKColor.Parse("#F95E62"),
            }
        };

        // Week Studies
        public static float Monday = 2;
        public static string MondayString = Monday.ToString();
        public static string MondayLabel = "Monday";
        public static float Tuesday = 7;
        public static string TuesdayString = Tuesday.ToString();
        public static string TuesdayLabel = "Tuesday";
        public static float Wednesday = 4;
        public static string WednesdayString = Wednesday.ToString();
        public static string WednesdayLabel = "Wednesday";
        public static float Thursday = 1;
        public static string ThursdayString = Thursday.ToString();
        public static string ThursdayLabel = "Thursday";
        public static float Friday = 0;
        public static string FridayString = Friday.ToString();
        public static string FridayLabel = "Friday";
        public static float Saturday = 0;
        public static string SaturdayString = Saturday.ToString();
        public static string SaturdayLabel = "Saturday";
        public static float Sunday = 0;
        public static string SundayString = Sunday.ToString();
        public static string SundayLabel = "Sunday";

        List<Entry> ThisWeekStudies = new List<Entry>
        {
            new Entry(Monday)
            {
                Color = SKColor.Parse("#F95E62"),
                Label = MondayLabel,
                ValueLabel = MondayString,
                ValueLabelColor = SKColor.Parse("#F95E62"),
            },
            new Entry(Tuesday)
            {
                Color = SKColor.Parse("#FF883E"),
                Label = TuesdayLabel,
                ValueLabel = TuesdayString,
                ValueLabelColor = SKColor.Parse("#FF883E"),
            },
            new Entry(Wednesday)
            {
                Color = SKColor.Parse("#FFF166"),
                Label = WednesdayLabel,
                ValueLabel = WednesdayString,
                ValueLabelColor = SKColor.Parse("#FFF166"),
            },
            new Entry(Thursday)
            {
                Color = SKColor.Parse("#73C92D"),
                Label = ThursdayLabel,
                ValueLabel = ThursdayString,
                ValueLabelColor = SKColor.Parse("#73C92D"),
            },
            new Entry(Friday)
            {
                Color = SKColor.Parse("#00CFBB"),
                Label = FridayLabel,
                ValueLabel = FridayString,
                ValueLabelColor = SKColor.Parse("#00CFBB"),
            },
            new Entry(Saturday)
            {
                Color = SKColor.Parse("#4CB4E7"),
                Label = SaturdayLabel,
                ValueLabel = SaturdayString,
                ValueLabelColor = SKColor.Parse("#4CB4E7"),
            },
            new Entry(Sunday)
            {
                Color = SKColor.Parse("#0074A2"),
                Label = SundayLabel,
                ValueLabel = SundayString,
                ValueLabelColor = SKColor.Parse("#0074A2"),
            },

        };

        // Recent Studies Chart
        public static float TotalLastMonth = 46;
        public static string TotalLastMonthLabel = "Last Month";
        public static string TotalLastMonthString = TotalLastMonth.ToString();

        public static float TotalFourWeeksAgo = 28;
        public static string TotalFourWeeksAgoLabel = "4 Weeks Ago";
        public static string TotalFourWeeksAgoString = TotalFourWeeksAgo.ToString();

        public static float TotalThreeWeeksAgo = 18;
        public static string TotalThreeWeeksAgoLabel = "3 Weeks Ago";
        public static string TotalThreeWeeksAgoString = TotalThreeWeeksAgo.ToString();

        public static float TotalTwoWeeksAgo = 5;
        public static string TotalTwoWeeksAgoLabel = "2 Weeks Ago";
        public static string TotalTwoWeeksAgoString = TotalTwoWeeksAgo.ToString();

        public static float TotalLastWeek = 17;
        public static string TotalLastWeekLabel = "Last Week";
        public static string TotalLastWeekString = TotalLastWeek.ToString();

        public static float TotalThisWeek = 8;
        public static string TotalThisWeekLabel = "This Week";
        public static string TotalThisWeekString = TotalThisWeek.ToString();

        List<Entry> RecentsStudies = new List<Entry>
        {
            new Entry(TotalLastMonth)
            {
                Color =  SKColor.Parse("#28008C"),
                Label = TotalLastMonthLabel,
                ValueLabel = TotalLastMonthString,
                ValueLabelColor = SKColor.Parse("#28008C"),
            },
            new Entry(TotalFourWeeksAgo)
            {
                Color =  SKColor.Parse("#0074A2"),
                Label = TotalFourWeeksAgoLabel,
                ValueLabel = TotalFourWeeksAgoString,
                ValueLabelColor = SKColor.Parse("#0074A2"),
            },
            new Entry(TotalThreeWeeksAgo)
            {
                Color =  SKColor.Parse("#0074A2"),
                Label = TotalThreeWeeksAgoLabel,
                ValueLabel = TotalThreeWeeksAgoString,
                ValueLabelColor = SKColor.Parse("#0074A2"),
            },
            new Entry(TotalTwoWeeksAgo)
            {
                Color =  SKColor.Parse("#6A9DE0"),
                Label = TotalTwoWeeksAgoLabel,
                ValueLabel = TotalTwoWeeksAgoString,
                ValueLabelColor = SKColor.Parse("#6A9DE0"),
            },
            new Entry(TotalLastWeek)
            {
                Color =  SKColor.Parse("#4CB4E7"),
                Label = TotalLastWeekLabel,
                ValueLabel = TotalLastWeekString,
                ValueLabelColor = SKColor.Parse("#4CB4E7"),
            },
            new Entry(TotalThisWeek)
            {
                Color =  SKColor.Parse("#00CFBB"),
                Label = TotalThisWeekLabel,
                ValueLabel = TotalThisWeekString,
                ValueLabelColor = SKColor.Parse("#00CFBB"),
            },
        };


        // Global Year Studies Chart
        public static float September = 215;
        public static float October = 164;
        public static float November = 178;
        public static float December = 97;
        public static float January = 276;
        public static float February = 116;
        public static float March = 231;
        public static float April = 124;
        public static float May = 68;
        public static float June = 470;
        public static float July = 6;
        public static float August = 3;

        public static string SeptemberString = September.ToString();
        public static string SeptemberLabel = "September";
        public static string OctoberString = October.ToString();
        public static string OctoberLabel = "October";
        public static string NovemberString = November.ToString();
        public static string NovemberLabel = "November";
        public static string DecemberString = December.ToString();
        public static string DecemberLabel = "December";
        public static string JanuaryString = January.ToString();
        public static string JanuaryLabel = "January";
        public static string FebruaryString = February.ToString();
        public static string FebruaryLabel = "February";
        public static string MarchString = March.ToString();
        public static string MarchLabel = "March";
        public static string AprilString = April.ToString();
        public static string AprilLabel = "April";
        public static string MayString = May.ToString();
        public static string MayLabel = "May";
        public static string JuneString = June.ToString();
        public static string JuneLabel = "June";
        public static string JulyString = July.ToString();
        public static string JulyLabel = "July";
        public static string AugustString = August.ToString();
        public static string AugustLabel = "August";

        List<Entry> YearStudies = new List<Entry>
        {
            new Entry(September)
            {
                Color =  SKColor.Parse("#D0B7D5"),
                Label = SeptemberLabel,
                ValueLabel = SeptemberString,
                ValueLabelColor = SKColor.Parse("#D0B7D5"),
            },
            new Entry(October)
            {
                Color =  SKColor.Parse("#A288D9"),
                Label = OctoberLabel,
                ValueLabel = OctoberString,
                ValueLabelColor = SKColor.Parse("#A288D9"),
            },
            new Entry(November)
            {
                Color =  SKColor.Parse("#BF53B6"),
                Label = NovemberLabel,
                ValueLabel = NovemberString,
                ValueLabelColor = SKColor.Parse("#BF53B6"),
            },
            new Entry(December)
            {
                Color = SKColor.Parse("#28008C"),
                Label = DecemberLabel,
                ValueLabel = DecemberString,
                ValueLabelColor = SKColor.Parse("#28008C"),
            },
            new Entry(January)
            {
                Color = SKColor.Parse("#0074A2"),
                Label = JanuaryLabel,
                ValueLabel = JanuaryString,
                ValueLabelColor = SKColor.Parse("#0074A2"),
            },
            new Entry(February)
            {
                Color = SKColor.Parse("#4CB4E7"),
                Label = FebruaryLabel,
                ValueLabel = FebruaryString,
                ValueLabelColor = SKColor.Parse("#4CB4E7"),
            },
            new Entry(March)
            {
                Color = SKColor.Parse("#00CFBB"),
                Label = MarchLabel,
                ValueLabel = FebruaryString,
                ValueLabelColor = SKColor.Parse("#00CFBB"),
            },
            new Entry(April)
            {
                Color = SKColor.Parse("#73C92D"),
                Label = AprilLabel,
                ValueLabel = AprilString,
                ValueLabelColor = SKColor.Parse("#73C92D"),
            },
            new Entry(May)
            {
                Color = SKColor.Parse("#FFF116"),
                Label = MayLabel,
                ValueLabel = MayString,
                ValueLabelColor = SKColor.Parse("#FFF116"),
            },
            new Entry(June)
            {
                Color = SKColor.Parse("#FF883E"),
                Label = JuneLabel,
                ValueLabel = JuneString,
                ValueLabelColor = SKColor.Parse("#FF883E"),
            },
            new Entry(July)
            {
                Color = SKColor.Parse("#FF8B9A"),
                Label = JulyLabel,
                ValueLabel = JulyString,
                ValueLabelColor = SKColor.Parse("#FF8B9A"),
            },
            new Entry(August)
            {
                Color = SKColor.Parse("#F95E62"),
                Label = AugustLabel,
                ValueLabel = AugustString,
                ValueLabelColor = SKColor.Parse("#F95E62"),
            },
        };

        // Color Popularity Chart
        public static float BlackFolders = 26;
        public static float WhiteFolders = 36;
        public static float LilacFolders = 32;
        public static float VioletFolders = 32;
        public static float PurpleFolders = 24;
        public static float PinkFolders = 30;
        public static float StrawberryFolders = 32;
        public static float RedFolders = 39;
        public static float OrangeFolders = 36;
        public static float YellowFolders = 31;
        public static float GreenFolders = 28;
        public static float IceMintFolders = 43;
        public static float BlueTurquoiseFolders = 25;
        public static float BlueFolders = 34;

        public static string BlackFoldersString = BlackFolders.ToString();
        public static string BlackFoldersLabel = "Black";
        public static string WhiteFoldersString = WhiteFolders.ToString();
        public static string WhiteFoldersLabel = "White";

        public static string LilacFoldersString = LilacFolders.ToString();
        public static string LilacFoldersLabel = "Lilac";
        public static string VioletFoldersString = VioletFolders.ToString();
        public static string VioletFoldersLabel = "Violet";
        public static string PurpleFoldersString = PurpleFolders.ToString();
        public static string PurpleFoldersLabel = "Purple";
        public static string PinkFoldersString = PinkFolders.ToString();
        public static string PinkFoldersLabel = "Pink";

        public static string StrawberryFoldersString = StrawberryFolders.ToString();
        public static string StrawberryFoldersLabel = "Strawberry";
        public static string RedFoldersString = RedFolders.ToString();
        public static string RedFoldersLabel = "Red";
        public static string OrangeFoldersString = OrangeFolders.ToString();
        public static string OrangeFoldersLabel = "Orange";
        public static string YellowFoldersString = YellowFolders.ToString();
        public static string YellowFoldersLabel = "Yellow";

        public static string GreenFoldersString = GreenFolders.ToString();
        public static string GreenFoldersLabel = "Green";
        public static string IceMintFoldersString = IceMintFolders.ToString();
        public static string IceMintFoldersLabel = "Cyan";
        public static string BlueTurquoiseFoldersString = BlueTurquoiseFolders.ToString();
        public static string BlueTurquoiseFoldersLabel = "Turquoise";
        public static string BlueFoldersString = BlueFolders.ToString();
        public static string BlueFoldersLabel = "Blue";

        List<Entry> colorsPopularity = new List<Entry>
        {
            new Entry(BlackFolders)
            {
                Color = SKColor.Parse("#615D59"),
                Label = BlackFoldersLabel,
                ValueLabel = BlackFoldersString,
                ValueLabelColor = SKColor.Parse("#615D59"),
            },
            new Entry(LilacFolders)
            {
                Color = SKColor.Parse("#D0B7D5"),
                Label = LilacFoldersLabel,
                ValueLabel = LilacFoldersString,
                ValueLabelColor = SKColor.Parse("D0B7D5"),
            },
            new Entry(VioletFolders)
            {
                Color = SKColor.Parse("#A288D9"),
                Label = VioletFoldersLabel,
                ValueLabel = VioletFoldersString,
                ValueLabelColor = SKColor.Parse("#A288D9"),
            },
            new Entry(PurpleFolders)
            {
                Color = SKColor.Parse("#BF53B6"),
                Label = PurpleFoldersLabel,
                ValueLabel = PurpleFoldersString,
                ValueLabelColor = SKColor.Parse("#BF53B6"),
            },
            new Entry(PinkFolders)
            {
                Color = SKColor.Parse("#EA60A7"),
                Label = PinkFoldersLabel,
                ValueLabel = PinkFoldersString,
                ValueLabelColor = SKColor.Parse("#EA60A7"),
            },
            new Entry(StrawberryFolders)
            {
                Color = SKColor.Parse("#FF8B9A"),
                Label = StrawberryFoldersLabel,
                ValueLabel = StrawberryFoldersString,
                ValueLabelColor = SKColor.Parse("#FF8B9A"),
            },
            new Entry(RedFolders)
            {
                Color = SKColor.Parse("#F95E62"),
                Label = RedFoldersLabel,
                ValueLabel = RedFoldersString,
                ValueLabelColor = SKColor.Parse("#F95E62"),
            },
            new Entry(OrangeFolders)
            {
                Color = SKColor.Parse("#FF883E"),
                Label = OrangeFoldersLabel,
                ValueLabel = OrangeFoldersString,
                ValueLabelColor = SKColor.Parse("#FF883E"),
            },
            new Entry(YellowFolders)
            {
                Color = SKColor.Parse("#FFF166"),
                Label = YellowFoldersLabel,
                ValueLabel = YellowFoldersString,
                ValueLabelColor = SKColor.Parse("#FFF166"),
            },
            new Entry(GreenFolders)
            {
                Color = SKColor.Parse("#73C92D"),
                Label = GreenFoldersLabel,
                ValueLabel = GreenFoldersString,
                ValueLabelColor = SKColor.Parse("#73C92D"),
            },
            new Entry(IceMintFolders)
            {
                Color = SKColor.Parse("#00CFBB"),
                Label = IceMintFoldersLabel,
                ValueLabel = IceMintFoldersString,
                ValueLabelColor = SKColor.Parse("#00CFBB"),
            },
            new Entry(BlueTurquoiseFolders)
            {
                Color = SKColor.Parse("#4CB4E7"),
                Label = BlueTurquoiseFoldersLabel,
                ValueLabel = BlueTurquoiseFoldersString,
                ValueLabelColor = SKColor.Parse("#4CB4E7"),
            },
            new Entry(BlueFolders)
            {
                Color = SKColor.Parse("#0074A2"),
                Label = BlueFoldersLabel,
                ValueLabel = BlueFoldersString,
                ValueLabelColor = SKColor.Parse("#0074A2"),
            },
            new Entry(WhiteFolders)
            {
                Color = SKColor.Parse("#FFFFFF"),
                Label = WhiteFoldersLabel,
                ValueLabel = WhiteFoldersString,
                ValueLabelColor = SKColor.Parse("#615D59"),
            },
        };

        // Chart Tasks %
        public static float FolderAndSharingTasks = 40;
        public static float AccountTasks = 86;
        public static float ScanningTasks = 70;
        public static float StudyTasks = 50;
        public static float MaxTasks = 100;

        public static string FolderAndSharingTasksString = FolderAndSharingTasks.ToString();
        public static string FolderAndSharingTasksLabel = "Folders & Sharing";
        public static string AccountTasksString = AccountTasks.ToString();
        public static string AccountTasksLabel = "Account";
        public static string ScanningTasksString = ScanningTasks.ToString();
        public static string ScanningTasksLabel = "Scanning";
        public static string StudyTasksString = StudyTasks.ToString();
        public static string StudyTasksLabel = "Studying";
        public static string MaxTasksString = MaxTasks.ToString();
        public static string MaxTasksLabel = "";

        List<Entry> TasksEntries = new List<Entry>
        {
            new Entry(MaxTasks)
            {
                Color = SKColor.Parse("#00FFFFFF"),
                Label = ScanningTasksLabel,
                ValueLabel = ScanningTasksString + "%",
                ValueLabelColor = SKColor.Parse("#F95E62"),
                TextColor = SKColor.Parse("#F95E62"),
            },
            new Entry(FolderAndSharingTasks)
            {
                Color = SKColor.Parse("#73C92D"),
                Label = FolderAndSharingTasksLabel,
                ValueLabel = FolderAndSharingTasksString + "%",
                ValueLabelColor = SKColor.Parse("#73C92D"),
                TextColor = SKColor.Parse("#73C92D"),
            },
            new Entry(AccountTasks)
            {
                Color = SKColor.Parse("#0074A2"),
                Label = AccountTasksLabel,
                ValueLabel = AccountTasksString + "%",
                ValueLabelColor = SKColor.Parse("#0074A2"),
                TextColor = SKColor.Parse("#0074A2"),
            },
            new Entry(ScanningTasks)
            {
                Color = SKColor.Parse("#F95E62"),
            },
            new Entry(StudyTasks)
            {
                Color = SKColor.Parse("#FF883E"),
                Label = StudyTasksLabel,
                ValueLabel = StudyTasksString + "%",
                ValueLabelColor = SKColor.Parse("#FF883E"),
                TextColor = SKColor.Parse("#FF883E"),
            },
        };


        public GlobalStatsView()
        {
            InitializeComponent();
            FirstChart.Chart = new BarChart()
            {
                Entries = BarChartEntries,
                LabelTextSize = 20f,
                BackgroundColor = SKColors.Transparent,
                LabelOrientation = Orientation.Horizontal,
                ValueLabelOrientation = Orientation.Horizontal,
            };

            TypeChart.Chart = new RadarChart()
            {
                Entries = DocumentTypeEntries,
                LabelTextSize = 16f,
                BackgroundColor = SKColors.Transparent,
                LineSize = 6,
                PointSize = 16,
            };

            ThisWeekStudiesChart.Chart = new BarChart()
            {
                Entries = ThisWeekStudies,
                LabelTextSize = 20f,
                BackgroundColor = SKColors.Transparent,
                LabelOrientation = Orientation.Horizontal,
                ValueLabelOrientation = Orientation.Horizontal,
            };

            LastStudiesChart.Chart = new LineChart()
            {
                Entries = RecentsStudies,
                LabelTextSize = 22f,
                LineMode = LineMode.Straight,
                PointMode = PointMode.Square,
                LineSize = 10f,
                PointSize = 20,
                BackgroundColor = SKColors.Transparent,
                ValueLabelOrientation = Orientation.Horizontal,
            };

            GlobalYearStudiesChart.Chart = new LineChart()
            {
                Entries = YearStudies,
                LabelTextSize = 18f,
                LineSize = 16,
                BackgroundColor = SKColors.Transparent,
                ValueLabelOrientation = Orientation.Horizontal,
            };

            ColorPopularityChart.Chart = new PointChart()
            {
                Entries = colorsPopularity,
                PointMode = PointMode.Square,
                BackgroundColor = SKColors.Transparent,
                ValueLabelOrientation = Orientation.Horizontal,
                PointAreaAlpha = 180,
            };

            TasksChart.Chart = new RadialGaugeChart()
            {
                Entries = TasksEntries,
                LineSize = 26,
                LabelTextSize = 24,
                BackgroundColor = SKColors.Transparent,
            };

        }
    }
}
