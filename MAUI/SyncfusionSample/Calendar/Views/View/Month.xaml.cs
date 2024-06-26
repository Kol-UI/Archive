using SampleBrowser.Maui.Base;
using Syncfusion.Maui.Calendar;

namespace SampleBrowser.Maui.Calendar.SfCalendar
{
    /// <summary>
    /// Interaction logic for GettingStarted.xaml
    /// </summary>
    public partial class Month : SampleView
    {
        /// <summary>
        /// Background color for border control. Border control will not shown on mobile platforms.
        /// </summary>
        public Color BGColor { get; set; }

        /// <summary>
        /// Stroke color for border control. Border control will not shown on mobile platforms.
        /// </summary>
        public Color StrokeColor { get; set; }

        /// <summary>
        /// Check the application theme is light or dark.
        /// </summary>
        private bool isLightTheme = Application.Current?.RequestedTheme == AppTheme.Light;

        /// <summary>
        /// Initializes a new instance of the <see cref="Month" /> class.
        /// </summary>
        public Month()
        {
            InitializeComponent();
#if MACCATALYST || (!ANDROID && !IOS)
            this.Background = isLightTheme ? Brush.White : (Brush)Color.FromRgba("#1C1B1F");
            this.Margin = new Thickness(-4, -4, -6, -6);
            this.BGColor = isLightTheme ? Color.FromArgb("#F7F2FB") : Color.FromArgb("#25232A");
            this.StrokeColor = Colors.Transparent;
#else
            this.BGColor = Colors.Transparent;
            this.StrokeColor = Colors.Transparent;
#endif

            this.BindingContext = this;
#if IOS || MACCATALYST
            this.border.IsVisible = true;
            this.month1.SelectedDate = DateTime.Now;
#else
            this.frame.IsVisible = true;
            this.month.SelectedDate = DateTime.Now;
#endif
        }
    }
}