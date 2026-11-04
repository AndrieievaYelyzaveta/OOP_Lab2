using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть висоту трикутника (h): ");
        int h = int.Parse(Console.ReadLine());
        for (int i = 1; i <= h; i++)
        {
            for (int s = 1; s <= h - i; s++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}