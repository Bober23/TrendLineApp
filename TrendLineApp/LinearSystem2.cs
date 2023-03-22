using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LabVMath_1
{
    class LinearSystem2
    {
        private static int rank = 2;
        private double[,] A = new double[rank, rank];
        private double[] B = new double[rank];
        private double[] coefficents= new double[rank];
        public LinearSystem2(MyPoint[] points)
        {
            foreach (var point in points)
            {
                A[0, 0] += Math.Pow(point.x,2);
                A[0, 1] += point.x;
                A[1, 0] += point.x;
                B[0] += point.y*point.x;
                B[1] += point.y;
            }
            A[1, 1] = points.Length;
        }
        public void Gauss()
        {
            for (int i = 0; i < rank - 1; i++)  //прямой ход
            {
                for (int j = i + 1; j < rank; j++)
                {
                    A[i, j] = A[i, j] / A[i, i];
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
                    B[j] = B[j] - B[i] * coefficent;
                }
            }
            for (int i = rank - 1; i >= 0; i--)
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
            foreach(var elem in A)
            {
                Console.WriteLine(elem);
            }
        }
        public void PrintCoef()
        {
            Console.WriteLine($"Для линейной: А = {coefficents[0]}, B = {coefficents[1]}");
        }
    }
}
