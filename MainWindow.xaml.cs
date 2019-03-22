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

namespace _184784llipsedrawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            for (int i = 7; i >= 0; i--)
            {
                    InitializeComponent();
                    Ellipse e = new Ellipse();
                    e.Height = i * 100;
                    e.Width = i * 100;

                    
                    if (i % 2 == 0)
                    {
                        e.Fill = Brushes.Red;
                    }
                    else
                    {
                        e.Fill = Brushes.Blue;
                    }
                    canvas.Children.Add(e);
                    Canvas.SetTop(e, 480 -(e.Width / 2));
                    Canvas.SetLeft(e, 480 -(e.Width / 2));
            }
        }
    }
}





  
