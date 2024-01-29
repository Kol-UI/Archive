using System.Windows;

namespace DrinkOrder
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btOrderDrink_Click(object sender, RoutedEventArgs e)
		{
			int result;
			if (string.IsNullOrWhiteSpace(tbDrink.Text))
				MessageBox.Show("No drink ordered");
			else if (string.IsNullOrWhiteSpace(tbSugars.Text))
				MessageBox.Show($"You have ordered {tbDrink.Text}");
			else if (int.TryParse(tbSugars.Text, out result))
				MessageBox.Show($"You have ordered {tbDrink.Text} with {result} sugars");
			else
				MessageBox.Show("Enter a valid number for the sugars");
		}
	}
}
