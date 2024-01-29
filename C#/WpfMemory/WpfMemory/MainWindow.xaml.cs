using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace WpfMemory
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool FirstCard = true;

        Button FirstButton ;

        int ValidPair=0;

        List<int> values;

        int NbValues;

        DispatcherTimer _timer;
        TimeSpan _time;

        DispatcherTimer dispatcherTimer;
        DispatcherTimer FreezeTimer;
        Button button;

        public MainWindow()
        {
            InitializeComponent();
            Random rand = new Random();
            values = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5 };
            NbValues = values.Count();
            foreach (var button in board.Children.OfType<Button>())
            {
                int val = rand.Next(0, values.Count);
                button.Tag = values[val];
                values.RemoveAt(val);
            }
            Chrono();
        }



        private void Chrono()
        {
            _time = TimeSpan.FromSeconds(30);
            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                compteur.Content = _time.ToString();
                if (ValidPair == NbValues/2)
                {
                    MessageBox.Show("Gagné!");
                    _timer.Stop();
                }
                else if (_time.Seconds==0)
                {
                    MessageBox.Show("Perdu");
                    _timer.Stop();

                }

                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button = (Button)sender;
            if ((int)button.Tag == 5)
            {
                if (FirstButton != null || !FirstCard)
                {

                    FirstButton.Click += Button_Click;
                    FirstButton.Content = "?";
                }
                DisableAll();
                FreezeTimer = new DispatcherTimer();
                FreezeTimer.Interval = new TimeSpan(0, 0, 2);
                FreezeTimer.Tick += new EventHandler(Freeze);
                FreezeTimer.Start();

                button.Content = "Trap!";
                FirstCard = false;

            }
            else
            {
               

                button.Content = button.Tag;
                if (FirstCard)
                {
                    FirstButton = button;
                    button.Click -= Button_Click;
                }
                else
                {
                    if ((int)FirstButton.Tag == (int)button.Tag)
                    {
                        FirstButton.IsEnabled = false;
                        button.IsEnabled = false;
                        ValidPair += 1;
                    }
                    else
                    {
                        
                        DisableAll();
                        dispatcherTimer = new DispatcherTimer();
                        dispatcherTimer.Interval = new TimeSpan(0, 0, 0,0,500);
                        dispatcherTimer.Tick += new EventHandler(Dispatch);
                        dispatcherTimer.Start();



                    }
                }
            }

            FirstCard = !FirstCard;
        }






        private void EnableAll()
        {
            foreach (var button in board.Children.OfType<Button>())
            {
                button.Click += Button_Click;
            }
        }
        private void DisableAll()
        {
            foreach (var button in board.Children.OfType<Button>())
            {
                button.Click -= Button_Click;
            }
        }

        private void Freeze(object sender, EventArgs e)
        {

            button.IsEnabled = false;
            EnableAll();

            FreezeTimer.Stop();
        }

        private void Dispatch(object sender, EventArgs e)
        {
            button.Content = "?";
            FirstButton.Content = "?";
            EnableAll();

            dispatcherTimer.Stop();
        }
    }
}
