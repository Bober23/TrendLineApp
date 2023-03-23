using LabVMath_1;
using System;
using System.Windows;
using System.IO;
using ScottPlot;
using System.Windows.Documents;
using System.Collections.Generic;

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
            for (int i = 0; i < 10; i++)
            {
                points[i] = new MyPoint();
            }
        }

        //points X coordinates input
        private void X1_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (X1_TextChanged != null && X1.Text != "")
            {
                if (Y1.Text!="")
                    points[0].isValue = true;
                points[0].x = Convert.ToDouble(X1.Text);
            }
            else
                points[0].isValue = false;
        }
        private void X2_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (X2_TextChanged != null && X2.Text != "")
            {
                if (Y2.Text != "")
                    points[1].isValue = true;
                points[1].x = Convert.ToDouble(X2.Text);
            }
            else
                points[1].isValue = false;
        }
        private void X3_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (X3_TextChanged != null && X3.Text!="")
            {
                if (Y3.Text != "")
                    points[2].isValue = true;
                points[2].x = Convert.ToDouble(X3.Text);
            }
            else
                points[2].isValue = false;
        }
        private void X4_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (X4_TextChanged != null && X4.Text != "")
            {
                if (Y4.Text != "")
                    points[3].isValue = true;
                points[3].x = Convert.ToDouble(X4.Text);
            }
            else
                points[3].isValue = false;
        }
        private void X5_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (X5_TextChanged != null && X5.Text != "")
            {
                if (Y5.Text != "")
                    points[4].isValue = true;
                points[4].x = Convert.ToDouble(X5.Text);
            }
            else
                points[4].isValue = false;
        }
        private void X6_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (X6_TextChanged != null && X6.Text != "")
            {
                if (Y6.Text != "")
                    points[5].isValue = true;
                points[5].x = Convert.ToDouble(X6.Text);
            }
            else
                points[5].isValue = false;
        }
        private void X7_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (X7_TextChanged != null && X7.Text != "") 
            {
                if (Y7.Text != "")
                    points[6].isValue = true;
                points[6].x = Convert.ToDouble(X7.Text);
            }
            else
                points[6].isValue = false;
        }
        private void X8_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (X8_TextChanged != null && X8.Text != "")
            {
                if (Y8.Text != "")
                    points[7].isValue = true;
                points[7].x = Convert.ToDouble(X8.Text);
            }
            else
                points[7].isValue = false;
        }
        private void X9_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (X9_TextChanged != null && X9.Text != "")
            {
                if (Y9.Text != "")
                    points[8].isValue = true;
                points[8].x = Convert.ToDouble(X9.Text);
            }
            else
                points[8].isValue = false;
        }
        private void X10_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (X10_TextChanged != null && X10.Text != "")
            {
                if (Y10.Text != "")
                    points[9].isValue = true;
                points[9].x = Convert.ToDouble(X10.Text);
            }
            else
                points[9].isValue = false;
        }

        //points Y coordinates input
        private void Y1_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Y1_TextChanged != null && Y1.Text != "")
            {
                if (X1.Text != "")
                    points[0].isValue = true;
                points[0].y = Convert.ToDouble(Y1.Text);
            }
            else
                points[0].isValue = false;
        }
        private void Y2_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Y2_TextChanged != null && Y2.Text != "")
            {
                if (X2.Text != "")
                    points[1].isValue = true;
                points[1].y = Convert.ToDouble(Y2.Text);
            }
            else
                points[1].isValue = false;
        }
        private void Y3_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Y3_TextChanged != null && Y3.Text != "")
            {
                if (X3.Text != "")
                    points[2].isValue = true;
                points[2].y = Convert.ToDouble(Y3.Text);
            }
            else
                points[2].isValue = false;
        }
        private void Y4_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        { 
            if (Y4_TextChanged != null && Y4.Text != "")
            {
                if (X4.Text != "")
                    points[3].isValue = true;
                points[3].y = Convert.ToDouble(Y4.Text);
            }
            else
                points[3].isValue = false;
        }
        private void Y5_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Y5_TextChanged != null && Y5.Text != "")
            {
                if (X5.Text != "")
                    points[4].isValue = true;
                points[4].y = Convert.ToDouble(Y5.Text);
            }
            else
                points[4].isValue = false;
        }
        private void Y6_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Y6_TextChanged != null && Y6.Text != "")
            {
                if (X6.Text != "")
                    points[5].isValue = true;
                points[5].y = Convert.ToDouble(Y6.Text);
            }
            else
                points[5].isValue = false;
        }
        private void Y7_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Y7_TextChanged != null && Y7.Text != "")
            {
                if (X7.Text != "")
                    points[6].isValue = true;
                points[6].y = Convert.ToDouble(Y7.Text);
            }
            else
                points[6].isValue = false;
        }
        private void Y8_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Y8_TextChanged != null && Y8.Text != "")
            {
                if (X8.Text != "")
                    points[7].isValue = true;
                points[7].y = Convert.ToDouble(Y8.Text);
            }
            else
                points[7].isValue = false;
        }
        private void Y9_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Y9_TextChanged != null && Y9.Text != "")
            {
                if (X9.Text != "")
                    points[8].isValue = true;
                points[8].y = Convert.ToDouble(Y9.Text);
            }
            else
                points[8].isValue = false;
        }
        private void Y10_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (Y10_TextChanged != null && Y10.Text != "")
            {
                if (X10.Text != "")
                    points[9].isValue = true;
                points[9].y = Convert.ToDouble(Y10.Text);
            }
            else
                points[9].isValue = false;
        }

        //buttons
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FileFunctions.SetPoints(points);
            var LinearSystem = new LinearSystem2(points);
            LinearSystem.Gauss();
            LinearCoefLabel.Content = "A="+ Math.Round(LinearSystem.coefficents[0], 3) + " B="+Math.Round(LinearSystem.coefficents[1], 3);
            var LinearSystemSquare = new LinearSystem3(points);
            LinearSystemSquare.Gauss();
            SquareCoefLabel.Content = "A=" + Math.Round(LinearSystemSquare.coefficents[0],3) + " B=" + Math.Round(LinearSystemSquare.coefficents[1], 3) + " C=" + Math.Round(LinearSystemSquare.coefficents[2], 3);
            MakeChart(LinearSystem, LinearSystemSquare);
        }

        private void LoadFromFileButton_Click(object sender, RoutedEventArgs e)
        {
            points = FileFunctions.GetPoints();
            if (points[0].isValue == true)
            {
                X1.Text = Convert.ToString(points[0].x);
                Y1.Text = Convert.ToString(points[0].y);
            }
            if (points[1].isValue == true)
            {
                X2.Text = Convert.ToString(points[1].x);
                Y2.Text = Convert.ToString(points[1].y);
            }
            if (points[2].isValue == true)
            {
                X3.Text = Convert.ToString(points[2].x);
                Y3.Text = Convert.ToString(points[2].y);
            }
            if (points[3].isValue == true)
            {
                X4.Text = Convert.ToString(points[3].x);
                Y4.Text = Convert.ToString(points[3].y);
            }
            if (points[4].isValue == true)
            {
                X5.Text = Convert.ToString(points[4].x);
                Y5.Text = Convert.ToString(points[4].y);
            }
            if (points[5].isValue == true)
            {
                X6.Text = Convert.ToString(points[5].x);
                Y6.Text = Convert.ToString(points[5].y);
            }
            if (points[6].isValue == true)
            {
                X7.Text = Convert.ToString(points[6].x);
                Y7.Text = Convert.ToString(points[6].y);
            }
            if (points[7].isValue == true)
            {
                X8.Text = Convert.ToString(points[7].x);
                Y8.Text = Convert.ToString(points[7].y);
            }
            if (points[8].isValue == true)
            {
                X9.Text = Convert.ToString(points[8].x);
                Y9.Text = Convert.ToString(points[8].y);
            }
            if (points[9].isValue == true)
            {
                X10.Text = Convert.ToString(points[9].x);
                Y10.Text = Convert.ToString(points[9].y);
            }
        }
        
        //work with graphic
        private void MakeChart(LinearSystem2 linearSystem, LinearSystem3 squareSystem)
        {
            double? maxX = null, minX = null;
            MainChart.Reset();
            foreach (var point in points) 
            {
                if (point.isValue == true)
                {
                    if (maxX == null)
                    {
                        maxX = point.x; minX = point.x;
                    }
                    else
                    {
                        if (point.x < minX)
                        {
                            minX = point.x;
                        }
                        if (point.x>maxX)
                        {
                            maxX = point.x;
                        }
                    }
                    MainChart.Plot.AddPoint(point.x, point.y,System.Drawing.Color.Red);
                }
            }
            double left = minX != null ? (minX > 0 ? left = (double)minX - 2 * (int)points[5].x : (double)minX + 2 * (int)points[5].x) : 0;
            double right = maxX != null ? (maxX > 0 ? right = (double)maxX + 2 * (int)points[5].x : (double)maxX - 2 * (int)points[5].x) : 0;
            //making linear graphic
            var linearX = new double[] { left, right };
            var linearY = new double[] { left * linearSystem.coefficents[0] + linearSystem.coefficents[1], right * linearSystem.coefficents[0] + linearSystem.coefficents[1] };
            MainChart.Plot.AddScatter(linearX, linearY,System.Drawing.Color.Blue,1,1);
            //making square graphic
            int numberOfPoints = (int)(right-left)*1000;  
            double[] xPoints = new double[numberOfPoints];
            double[] yPoints = new double[numberOfPoints];
            double x = left;
            double y;
            for (int i = 0; i<numberOfPoints;i++)
            {
                y = Math.Pow(x, 2) * squareSystem.coefficents[0] + x * squareSystem.coefficents[1]+squareSystem.coefficents[2];
                xPoints[i] = x;
                yPoints[i] = y;
                x+=0.001;
            }
            MainChart.Plot.AddScatter(xPoints, yPoints,System.Drawing.Color.Green,1,1);
            MainChart.Refresh();
        }
    }
}
