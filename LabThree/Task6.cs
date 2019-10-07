using System;
using System.Collections.Generic;
using System.Text;

namespace LabThree
{
    class Task6
    {
        internal static void Do()
        {
            int[] array = {2, 4, 2, -10, -100, 50, -133};
            Console.WriteLine(minRecurive(array, array.Length));

        }
        internal static int sumInterative(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum+= array[i];
            }
            return sum;
        }

        static int sumRecursive(int[] array, int i = 0)
        {
            if (array[i] == array[array.Length - 1])
            {
                return array[array.Length - 1];
            }                                                                              
            return array[i] + sumRecursive(array, i + 1);
        }
        internal static int minInterative(int[] A)
        {
            int sum = 0;
            for(int i = -1; i<A.Length; i++)
            {
                if (i==-1)
                {
                    sum = A[i + 1];
                }
                else if(A[i]<sum)
                {
                    sum = A[i];
                }
            }
            return sum;
        }
        static int minRecurive(int[] arr, int length)
        {
            if (arr.Length == 1){
                return arr[0];
            }
            if (arr[length-1]> arr[length - 2]){
                return minRecurive(arr, length - 1);
            }
            else
            {
                return arr[length - 1];
            }
        }
    }
}
