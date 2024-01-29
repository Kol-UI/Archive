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

namespace WpfBalls
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            MouseHelper mh = new MouseHelper(camera);
            mh.EventSource = viewPort;
          
            BallCubeBuilder bcb = new BallCubeBuilder(visualModel);
            bcb.BuildSlice("Mars.jpg",  -2.0);
            bcb.BuildSlice("Venus.jpg",  0.0);
            bcb.BuildSlice("Uranus.jpg", 2.0);
        }
    }
}
