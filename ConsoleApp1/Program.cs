using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть рік: ");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        if (isLeap)
        {
            Console.WriteLine("{0} рік - високосний.", year);
        }
        else
        {
            Console.WriteLine("{0} рік - не високосний.", year);
        }
    }
}