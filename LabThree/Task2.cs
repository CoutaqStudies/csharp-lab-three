using System;
using System.Collections.Generic;
using System.Text;

namespace LabThree
{
    class Task2
    {
        internal static void Do()
        {
            int max = 100, min = 0;
            int[,] array = new int[7, 7];
            for(int i = 0; i <= Math.Sqrt(array.Length)-1; i++)
            {
                for (int j = 0; j <= Math.Sqrt(array.Length)-1;j++)
                {
                    Random rnd = new Random();
                    array[i, j] = rnd.Next(min, max);
                    Console.Write(array[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            for (int i = 0; i <= Math.Sqrt(array.Length) - 1; i++)
            {
                for (int j = 0; j <= Math.Sqrt(array.Length) - 1; j++)
                {
                    Console.Write(array[6-j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
