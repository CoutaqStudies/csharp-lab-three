using System;
using System.Collections.Generic;
using System.Text;

namespace LabThree
{
    class Task6
    {
        internal static void Do()
        {
            int[] array = { 2, 4, 6 , -1 , 10, -100, 0};
            Console.WriteLine(minInterative(array));

        }
        internal static int sumInterative(int[] A)
        {
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum+= A[i];
            }
            return sum;
        }
        private static int sumRecursive(int[] A)
        {
            int sum = A[0];
            return sum+sumRecursive(A);
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
        private static int minRecursive(int[] A)
        {
            int sum = A[0];
            return sum + sumRecursive(A);
        }
    }
}
