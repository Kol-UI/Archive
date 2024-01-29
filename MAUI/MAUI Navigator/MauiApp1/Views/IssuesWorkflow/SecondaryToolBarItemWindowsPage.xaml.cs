namespace MauiApp1.Views.IssuesWorkflow;

public partial class SecondaryToolBarItemWindowsPage : ContentPage
{
    private int _count = 0;

    public SecondaryToolBarItemWindowsPage()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        CounterBtn.Text = $"Clicked {++_count} time{(_count == 1 ? "" : "s")}";
        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}
