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
using System.Windows.Media.Animation;
using System.IO;
using System.Diagnostics;
namespace Click_Me_Tools
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation da = new DoubleAnimation(360, 0, new Duration(TimeSpan.FromSeconds(9)));
            RotateTransform rt = new RotateTransform();
            RotateImg.RenderTransform = rt;
            RotateImg2.RenderTransform = rt;
            RotateImg3.RenderTransform = rt;
            RotateImg.RenderTransformOrigin = new Point(0.5, 0.5);
            RotateImg2.RenderTransformOrigin = new Point(0.5, 0.5);
            RotateImg3.RenderTransformOrigin = new Point(0.5, 0.5);
            da.RepeatBehavior = RepeatBehavior.Forever;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);
        }

        private void btn(object sender, DragEventArgs e)
        {

        }

        private void btn_browse_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com"); 
        }

        private void btn_fb_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com"); 
        }

        private void btn_ytube_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com");
        }

        private void btn_music_click(object sender, RoutedEventArgs e)
        {
           Process virtualMouse = new Process();

           virtualMouse.StartInfo.FileName = "mpc-hc64.exe"; // Needs to be full path
           virtualMouse.StartInfo.Arguments = ""; // If you have any arguments

           bool result = virtualMouse.Start();

        }

        private void focus_btn(object sender, RoutedEventArgs e)
        {
            btn_browse.Visibility=Visibility.Visible;
        }

        
        
    }
}
