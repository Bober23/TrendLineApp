using LabVMath_1;
using System;
using System.Windows;
using System.IO;


namespace TrendLineApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MyPoint[] points = new MyPoint[10];
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new MyPoint();
            }
        }

        private void X1_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[0].x = Convert.ToDouble(X1.Text);
        }
        //points coordinates input
        private void X2_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[1].x = Convert.ToDouble(X1.Text);
        }
        private void X3_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[2].x = Convert.ToDouble(X1.Text);
        }
        private void X4_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[3].x = Convert.ToDouble(X1.Text);
        }
        private void X5_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[4].x = Convert.ToDouble(X1.Text);
        }
        private void X6_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[5].x = Convert.ToDouble(X1.Text);
        }
        private void X7_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[6].x = Convert.ToDouble(X1.Text);
        }
        private void X8_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[7].x = Convert.ToDouble(X1.Text);
        }
        private void X9_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[8].x = Convert.ToDouble(X1.Text);
        }
        private void X10_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[9].x = Convert.ToDouble(X1.Text);
        }

        private void Y1_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[0].y = Convert.ToDouble(Y1.Text);
        }
        private void Y2_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[1].y = Convert.ToDouble(Y1.Text);
        }
        private void Y3_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[2].y = Convert.ToDouble(Y1.Text);
        }
        private void Y4_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[3].y = Convert.ToDouble(Y1.Text);
        }
        private void Y5_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[4].y = Convert.ToDouble(Y1.Text);
        }
        private void Y6_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[5].y = Convert.ToDouble(Y1.Text);
        }
        private void Y7_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[6].y = Convert.ToDouble(Y1.Text);
        }
        private void Y8_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[7].y = Convert.ToDouble(Y1.Text);
        }
        private void Y9_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[8].y = Convert.ToDouble(Y1.Text);
        }
        private void Y10_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            points[9].y = Convert.ToDouble(Y1.Text);
        }
    }
}
