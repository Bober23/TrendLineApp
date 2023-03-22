using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabVMath_1
{
    class LinearSystem3  {
        private static int rank = 3;  //Здесь менять разрядность матрицы
        private double[,] A = new double[rank, rank];
        private double[] B = new double[rank];
        private double[] coefficents = new double[rank];
        public LinearSystem3(MyPoint[] points)
        {
            
            foreach (var point in points)
            {
                A[0, 0] += Math.Pow(point.x, 4);
                A[0, 1] += Math.Pow(point.x, 3);
                A[0, 2] += Math.Pow(point.x, 2);
                A[1, 0] += Math.Pow(point.x, 3);
                A[1, 1] += Math.Pow(point.x, 2);
                A[1, 2] += point.x;
                A[2, 0] += Math.Pow(point.x, 2);
                A[2, 1] += point.x;
                A[2, 2] += 1;
                for (int i = 0; i<rank; i++)
                {
                    B[i] += (point.y * Math.Pow(point.x, 2 - i));
                }
            }
            
        }
        public void Gauss()
        {
            for (int i = 0; i < rank-1; i++)  //прямой ход
            { 
                for (int j = i+1;j< rank; j++)
                {
                    A[i,j] = A[i,j]/A[i,i];
                }
                B[i] = B[i] / A[i, i];
                A[i, i] = 1;
                for (int j = i + 1; j < rank; j++)
                {
                    double coefficent = A[j, i];
                    for (int k = 0; k < rank; k++)
                    {
                        A[j, k] = A[j, k] - (A[i, k] * coefficent);
                    }
                    B[j] = B[j] - B[i]*coefficent;
                }
            } 
            for (int i = rank-1; i >= 0; i--)
            {
                coefficents[i] = B[i] / A[i, i];
                for (int j = 0; j < i; j++)
                {
                    B[j] = B[j] - A[j, i] * coefficents[i];
                }
            }
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < rank; i++)
            {
                Console.WriteLine($"{A[i,0]}  {A[i,1]}  {A[i,2]} ||| {B[i]}");
            }
        }
        public void PrintCoef()
        {
            Console.WriteLine($"Для квадратичной: А = {coefficents[0]}, B = {coefficents[1]} C = {coefficents[2]}");
        }
    }
}
