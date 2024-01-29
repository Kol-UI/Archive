using System;
using System.Collections.Generic;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;
using Entry = Microcharts.ChartEntry;

namespace ListView.Views
{
    public partial class XamanimationChart : ContentPage
    {
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





        public XamanimationChart()
        {
            InitializeComponent();

            ColorPopularityChart.Chart = new PointChart()
            {
                Entries = colorsPopularity,
                PointMode = PointMode.Square,
                BackgroundColor = SKColors.Transparent,
                ValueLabelOrientation = Orientation.Horizontal,
                PointAreaAlpha = 180,
            };
        }
    }
}
