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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Animations
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

        public void AnimateLabelRotation(object sender, RoutedEventArgs e)
        {
            Storyboard sbdLabelRotation = (Storyboard)FindResource("sbdLabelRotation");
            sbdLabelRotation.Begin(this);
        }

        public void AnimateLabelRotationInCode(object sender, RoutedEventArgs e)
        {
            DoubleAnimation oLabelAngleAnimation
              = new DoubleAnimation();

            oLabelAngleAnimation.From = 0;
            oLabelAngleAnimation.To = 360;
            oLabelAngleAnimation.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            oLabelAngleAnimation.RepeatBehavior = new RepeatBehavior(4);

            RotateTransform oTransform = (RotateTransform)lblHello3.RenderTransform;
            oTransform.BeginAnimation(RotateTransform.AngleProperty, oLabelAngleAnimation);
        }
    }
}
