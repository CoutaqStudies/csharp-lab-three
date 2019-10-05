using System;
using System.Collections.Generic;
using System.Text;

namespace LabThree
{
    class Task5
    {
        internal static void Do()
        {
            int max = 10, min = 0, arraySize = 5;
            int[,] A = new int[arraySize, arraySize];
            int[,] B = new int[arraySize, arraySize];
            int[,] C = new int[arraySize, arraySize];
            for (int i = 0; i <= arraySize - 1; i++)
            {
                for (int j = 0; j <= arraySize - 1; j++)
                {
                    Random rnd = new Random();
                    A[i, j] = rnd.Next(min, max);
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            for (int i = 0; i <= arraySize - 1; i++)
            {
                for (int j = 0; j <= arraySize - 1; j++)
                {
                    Random rnd = new Random();
                    B[i, j] = rnd.Next(min, max);
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i <= arraySize - 1; i++)
            {
                for (int j = 0; j <= arraySize - 1; j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k <= arraySize - 1; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
