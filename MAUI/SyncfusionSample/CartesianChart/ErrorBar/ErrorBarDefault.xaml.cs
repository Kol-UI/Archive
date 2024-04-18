using SampleBrowser.Maui.Base;
using Syncfusion.Maui.Charts;
using System.Collections.ObjectModel;

namespace SampleBrowser.Maui.CartesianChart.SfCartesianChart
{
    public partial class ErrorBarDefault : SampleView
    {

        #region Constructor

        #region  Public Constructor

        public ErrorBarDefault()
        {
            InitializeComponent();
        }
        
        public override void OnAppearing()
        {
            base.OnAppearing();
            hyperLinkLayout.IsVisible = !IsCardView;
            if (!IsCardView)
            {
                errorBarChart.Title = (Label)layout.Resources["title"];
                xAxis.Title = new ChartAxisTitle() { Text = "Material" };
                yAxis.Title = new ChartAxisTitle() { Text = "Thermal Coefficient" };
            }

        }

        public override void OnDisappearing()
        {
            base.OnDisappearing();
            errorBarChart.Handler?.DisconnectHandler();
        }

        #endregion

        #endregion

    }
}
