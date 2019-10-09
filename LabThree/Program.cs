using LabThree;
using System;
//written by Coutaq
namespace LabOne
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please select the task(1-11): ");
            int taskNumber;
            while (true)
            {
                try
                {
                    taskNumber = int.Parse(Console.ReadLine());
                    if (taskNumber < 1 || taskNumber > 12)
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
            switch (taskNumber)
            {
                case 1:
                    Task1.Do();
                    Program.Main(args);
                    break;
                case 2:
                    Task2.Do();
                    Program.Main(args);
                    break;
                case 3:
                    Task3.Do();
                    Program.Main(args);
                    break;
                case 4:
                    Task4.Do();
                    Program.Main(args);
                    break;
                case 5:
                    Task5.Do();
                    Program.Main(args);
                    break;
                case 6:
                    Task6.Do();
                    Program.Main(args);
                    break;
                case 7:
                    Task7.Do();
                    Program.Main(args);
                    break;
                case 8:
                    Task8.Do();
                    Program.Main(args);
                    break;
                case 9:
                    Task9.Do();
                    Program.Main(args);
                    break;
                case 10:
                    Task10.Do();
                    Program.Main(args);
                    break;
            }
        }
    }
}