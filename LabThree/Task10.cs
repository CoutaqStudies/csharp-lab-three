using System;
using System.Collections.Generic;
using System.Text;

namespace LabThree
{
    class Task10
    {
        internal static void Do()
        {
            int[] array = new int[3];
            for (int i = 0; i < array.Length; i++)
            {
                Random rnd = new Random();
                array[i] = rnd.Next(0, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
            int sumRight = 0, sumLeft = 0;
            for (int i = 0; i < array.Length; i++)
            {
                
                if (i < (array.Length/2))
                {
                    sumLeft += array[i];
                }
                else
                {
                    sumRight += array[i];
                }
            }
            Console.WriteLine("Sum of all numbers on the left: " + sumLeft);
            Console.WriteLine("Sum of all numbers on the right: " + sumRight);
            Console.WriteLine("Difference of the sums: " + (sumLeft - sumRight));
        }
    }
}