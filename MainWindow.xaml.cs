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

namespace Wpf2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(50);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Start();
        }

        public int MyAngle { get; set; } = 1;
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            var tr = new RotateTransform();
            tr.Angle = MyAngle;
            MyAngle += 1;
            //mylbl.RenderTransform = tr;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
