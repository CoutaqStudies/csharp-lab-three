using System;
using System.Collections.Generic;
using System.Text;

namespace LabThree
{
    class Task8
    {
        internal static void Do()
        {
            int[,] array = new int[4, 4];
            for (int i = 0; i <= Math.Sqrt(array.Length) - 1; i++)
            {
                for (int j = 0; j <= Math.Sqrt(array.Length) - 1; j++)
                {
                    Random rnd = new Random();
                    //array[i, j] = rnd.Next(0, 10);
                    array[i, j] = i+j;
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(FindMOfIJ(0,0,array));

        }
        //i actually know what to name this - findDeterminant  - but thats too boring
        static int ILegitDontKnowWhatToNameThis(int[,] Matrix)
        {
            return 0;
        }
        static double FindAOfIJ(int i, int j, int[,] matrix)
        {
            return Math.Pow(-1, i + j) * FindMOfIJ(i, j, matrix);
        }

        private static double FindMOfIJ(int i, int j, int[,] matrix)
        {
            int[,] new_matrix = new int[(int)(Math.Sqrt(matrix.Length) - 1), (int)(Math.Sqrt(matrix.Length) - 1)];
            new_matrix = TrimArray(i, j, matrix);
            Console.WriteLine("The matrix: ");
            for (int l = 0; l <= Math.Sqrt(new_matrix.Length) - 1; l++)
            {
                for (int m = 0; m <= Math.Sqrt(new_matrix.Length) - 1; m++)
                {
                    Console.Write(new_matrix[l, m] + " ");
                }
                Console.WriteLine();
            }
            if (new_matrix.Length == 4)
            {
                Console.WriteLine(matrix[0,0]+"*"+matrix[1,1]+"-"+matrix[0,1]+"*"+matrix[1,0]);
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            else
            {
                double determinant = 0;
                for(int k = 0; k< Math.Sqrt(new_matrix.Length); k++)
                {
                    if (k % 2 != 0)
                    {

                        Console.WriteLine("Determinant = " + determinant + " - " + new_matrix[0, k] + "*" + FindMOfIJ(k, 0, new_matrix));
                        determinant -= new_matrix[0, k] * FindMOfIJ(k, 0, new_matrix);
                    }
                    else
                    {
                        Console.WriteLine("Determinant = " + determinant + " + " + new_matrix[0, k] + "*" + FindMOfIJ(k, 0, new_matrix));
                        determinant += new_matrix[0, k] * FindMOfIJ(k, 0, new_matrix);
                    }
                }
                return determinant;
            }
        }
        public static int[,] TrimArray(int rowToRemove, int columnToRemove, int[,] originalArray)
        {
            int[,] result = new int[originalArray.GetLength(0) - 1, originalArray.GetLength(1) - 1];

            for (int i = 0, j = 0; i < originalArray.GetLength(0); i++)
            {
                if (i == rowToRemove)
                    continue;

                for (int k = 0, u = 0; k < originalArray.GetLength(1); k++)
                {
                    if (k == columnToRemove)
                        continue;

                    result[j, u] = originalArray[i, k];
                    u++;
                }
                j++;
            }

            return result;
        } 
    }
}
