using System;
using System.Collections.Generic;
using System.Text;

namespace LabThree
{
    class Task9
    {
        internal static void Do()
        {
            int[,] array = new int[9, 9];
            for (int i = 0; i <= Math.Sqrt(array.Length) - 1; i++)
            {
                for (int j = 0; j <= Math.Sqrt(array.Length) - 1; j++)
                {
                    Random rnd = new Random();
                    array[i, j] = rnd.Next(0, 10);
                }
            }
            for (int i = 0; i <= Math.Sqrt(array.Length) - 1; i++)
            {
                for (int j = 0; j <= Math.Sqrt(array.Length) - 1; j++)
                {
                    if (i-j>0)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(array[j, i] + " ");
                    } 
                }
                Console.WriteLine("");
            }

        }
    }
}