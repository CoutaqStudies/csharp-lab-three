using System;
using System.Collections.Generic;
using System.Text;

namespace LabThree
{
    class Task1
    {
        internal static void Do()
        {
            int num;
            int max = 45, min=-30;
            Console.Write("Please enter how much arrays: ");
            while (true)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num < 1)
                    {
                        throw new FormatException();
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            int[] array = new int[num];
            for(int i = 0; i < num; i++)
            {
                Random rnd = new Random();
                array[i] = rnd.Next(min, max);

            }
            int n = 0;
            for (int j = 0; j < num; j++)
            {
                Console.Write(array[j]+" ");
                n++;
                if (n>9)
                {
                    Console.WriteLine("");
                    n = 0;
                }
                
            }
            Console.WriteLine("");
            for(int j = num-1; j >= 0; j--)
            {
                if (array[j]>=0)
                {
                    Console.Write(array[j] + " ");
                }
            }
        }
    }  
}
