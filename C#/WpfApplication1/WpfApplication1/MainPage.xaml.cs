using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApplication1
{

	/// <summary>
	/// Logique d'interaction pour MainPage.xaml
	/// </summary>
	public partial class MainPage : Page
	{
		DispatcherTimer _timer;
		TimeSpan _time;

		public MainPage()
		{
			InitializeComponent();

			_time = TimeSpan.FromSeconds(10);
			_timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
			{
				label.Content = _time.ToString("");
				if (_time == TimeSpan.Zero)
				{
					NavigationService nav = NavigationService.GetNavigationService(this);
					nav.Navigate(new Uri("Page2.xaml", UriKind.RelativeOrAbsolute));
				}
				_time = _time.Add(TimeSpan.FromSeconds(-1));
			}, Application.Current.Dispatcher);

			_timer.Start();
		}
	}
}
