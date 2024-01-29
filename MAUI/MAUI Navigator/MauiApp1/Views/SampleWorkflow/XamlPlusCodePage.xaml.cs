namespace MauiApp1.Views.SampleWorkflow;

public partial class XamlPlusCodePage : ContentPage
{
	public XamlPlusCodePage()
	{
		InitializeComponent();
	}

	void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
	{
		valueLabel.Text = args.NewValue.ToString("F3");
	}

	async void OnButtonClicked(object sender, EventArgs args)
	{
		Button button = (Button)sender;
		await DisplayAlert("Clicked!", "The button labeled '" + button.Text + "' has been clicked", "OK");
	}
}