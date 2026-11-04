using System;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть математичний вираз:");
            string input = Console.ReadLine();

            DataTable table = new DataTable();
            var result = table.Compute(input, null);

            Console.WriteLine("Відповідь програми: {0}", result);
        }
    }
}