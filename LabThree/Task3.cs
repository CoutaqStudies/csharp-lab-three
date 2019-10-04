using System;
using System.Collections.Generic;
using System.Text;

namespace LabThree
{
    class Task3
    {
        internal static void Do()
        {
            int max = 100, min = 0;
            int arraySize = 3;
            int k = 0;
            int[] array = new int[arraySize];
            int[] new_array = new int[arraySize];
            for (int i = 0; i < array.Length; i++)
            {
                Random rnd = new Random();
                array[i] = rnd.Next(min, max);
                Console.Write(array[i] + " ");
            }
            Console.Write("Please enter k: ");
            while (true)
            {
                try
                {
                    k = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            for (int i = 0; i <arraySize; i++)
            {
                try
                {
                    new_array[i] = array[i+k];
                }catch(IndexOutOfRangeException)
                {
                    new_array[i] = array[i-arraySize+k];
                }
                
                Console.Write(new_array[i] + " ");
            }
        }
    }
}
