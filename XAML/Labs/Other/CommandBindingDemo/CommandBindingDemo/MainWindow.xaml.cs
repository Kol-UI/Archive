using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace CommandBindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public static RoutedCommand MyCommand = new RoutedCommand();

        private bool _helpCanExecute = true;

        public MainWindow()
        {
            InitializeComponent();

            CommandBinding cb = new CommandBinding(MyCommand,
                MyCommandExecute, MyCommandCanExecute);
            this.CommandBindings.Add(cb);
                        
            MyCommandButton.Command = MyCommand;

            KeyGesture kg = new KeyGesture(Key.M, ModifierKeys.Control);
            InputBinding ib = new InputBinding(MyCommand, kg);
            this.InputBindings.Add(ib);
        }

        private void HelpCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _helpCanExecute;
            e.Handled = true;
        }

        private void HelpExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Hey, I'm some help.");
        }

        private void MyCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void MyCommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("My Command!");
            _helpCanExecute = !_helpCanExecute;
        }
    }
}
