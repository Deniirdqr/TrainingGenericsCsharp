using System;
using TrainingSixteen;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> printService = new PrintService<string>();

            Console.Write("How many values? ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                string _value = Console.ReadLine();
                printService.AddValue(_value);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}