using System;
using System.Collections.Generic;
using System.Text;

namespace LabThree
{
    class Task4
    {
        internal static void Do()
        {

           
        }
        internal static int[, ] AddMatricies(int[, ] A, int[, ] B)
        {
            int[,] C = new int[3, 3];
            for (int i = 0; i < Math.Sqrt(A.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(A.Length); j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            return C;
        }
        internal static int[,] SubtractMatricies(int[,] A, int[,] B)
        {
            int[,] C = new int[3, 3];
            for (int i = 0; i < Math.Sqrt(A.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(A.Length); j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                }
            }
            return C;
        }
    }
}
