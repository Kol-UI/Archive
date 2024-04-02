using SampleBrowser.Maui.Base;

namespace SampleBrowser.Maui.Backdrop.SfBackdropPage;

public partial class InitialPage : SampleView
{
    public InitialPage()
	{
		InitializeComponent();
    }

	private void OpenBackdropPage(object sender, EventArgs e)
	{
        if (Application.Current != null && Application.Current.MainPage != null)
        {
            var page = Application.Current.MainPage as NavigationPage;
            if (page != null)
            {
                page.BarBackgroundColor = Application.Current.RequestedTheme == AppTheme.Light ? Color.FromArgb("#6750A4") : Color.FromArgb("#D0BCFF");
                page.BarTextColor = Application.Current.RequestedTheme == AppTheme.Light ? Colors.White : Color.FromArgb("#381E72");
            }
        }

        Navigation.PushAsync(new Backdrop(), true);
    }
}