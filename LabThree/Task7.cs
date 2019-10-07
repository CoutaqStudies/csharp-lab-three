using System;
using System.Collections.Generic;
using System.Text;

namespace LabThree
{
    class Task7
    {
        internal static void Do()
        {
            Console.WriteLine(FibbonacciNth(10));

        }
        static int FibbonacciNth(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return FibbonacciNth(n - 1)+FibbonacciNth(n - 2);
            }
        }
    }
}
