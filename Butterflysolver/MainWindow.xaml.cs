using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Numerics;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Butterflysolver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        double x0, x1, x2, x3, x4, x5, x6, x7;
        Complex jplus = new Complex(0, 1);
        Complex jminus = new Complex(0, -1);
        double zero = 0;
        double one = 1;
        
        public MainWindow()
        {
            
            InitializeComponent();       
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            x0 = float.Parse(input0.Text);
            x1 = float.Parse(input1.Text);
            x2 = float.Parse(input2.Text);
            x3 = float.Parse(input3.Text);
            x4 = float.Parse(input4.Text);
            x5 = float.Parse(input5.Text);
            x6 = float.Parse(input6.Text);
            x7 = float.Parse(input7.Text);
        }
    }
}
