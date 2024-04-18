using SampleBrowser.Maui.Base;

namespace SampleBrowser.Maui.CartesianChart.SfCartesianChart
{
    public partial class PlotBandRecurrence : SampleView
    {
        public PlotBandRecurrence()
        {
            InitializeComponent();
        }

        public override void OnDisappearing()
        {
            base.OnDisappearing();
            plotBandRecurrenceChart.Handler?.DisconnectHandler();
        }
    }
}