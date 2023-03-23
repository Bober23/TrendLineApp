using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabVMath_1;

namespace LabVMath_1
{
    static class FileFunctions
    {
        public static void SetPoints(MyPoint[] points)
        {
            StreamWriter File = new StreamWriter("Data.dat");
            for (int i = 0; i < 10; i++)
            {
                File.WriteLine(points[i].isValue);
                File.WriteLine(points[i].x);
                File.WriteLine(points[i].y);
            }
            File.Close();
        }
        public static MyPoint[] GetPoints()
        {
            MyPoint[] points = new MyPoint[10];
            if (File.Exists("Data.dat"))
            {
                StreamReader File = new StreamReader("Data.dat");
                string? buffer = null;
                for (int i = 0; i < 10; i++)
                {
                    points[i] = new MyPoint();
                    buffer = File.ReadLine();
                    if (buffer == null) break;
                    if (buffer == "True")
                    {
                        points[i].isValue = true;
                    }
                    else
                    {
                        points[i].isValue = false;
                    }
                    points[i].x = Convert.ToDouble(File.ReadLine());
                    points[i].y = Convert.ToDouble(File.ReadLine());
                }
                File.Close();
                if (buffer != null)
                {
                    return points;
                }
                else
                {
                    for (int i = 0; i < 10; i++)
                    {
                        points[i] = new MyPoint();
                    }
                    return points;
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    points[i] = new MyPoint();
                }
                return points;
            }
        }
    }
}
