using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int score = 0;
        Console.WriteLine("Current User Score: {0}", score);
        Console.WriteLine("Питання 1, яке найменше просте число?");
        Console.WriteLine("1.0");
        Console.WriteLine("2.1");
        Console.WriteLine("3.2");
        Console.WriteLine("4.3");
        Console.WriteLine();
        int answer1 = int.Parse(Console.ReadLine());
        if (answer1 == 3)
        {
            score += 100;
            Console.WriteLine("Correct answer");
        }
        else
        {
            Console.WriteLine("Wrong Answer");
            Console.WriteLine("кінець програми.");
            return;
        }
        Console.WriteLine();
        Console.WriteLine("Current User Score: {0}", score);
        Console.WriteLine("Питання 2, чому дорівнює факторіал числа 5?");
        Console.WriteLine("1.20");
        Console.WriteLine("2.60");
        Console.WriteLine("3.120");
        Console.WriteLine("4.100");
        Console.WriteLine();
        int answer2 = int.Parse(Console.ReadLine());
        if (answer2 == 3)
        {
            score += 100;
            Console.WriteLine("Correct answer");
        }
        else
        {
            Console.WriteLine("Wrong Answer");
            Console.WriteLine("кінець програми.");
            return;
        }
        Console.WriteLine();
        Console.WriteLine("Current User Score: {0}", score);
        Console.WriteLine("Питання 3, скільки граней має куб?");
        Console.WriteLine("1.4");
        Console.WriteLine("2.6");
        Console.WriteLine("3.8");
        Console.WriteLine("4.12");
        Console.WriteLine();
        int answer3 = int.Parse(Console.ReadLine());
        if (answer3 == 2)
        {
            score += 100;
            Console.WriteLine("Correct answer");
        }
        else
        {
            Console.WriteLine("Wrong Answer");
            Console.WriteLine("кінець програми.");
            return;
        }
        Console.WriteLine();
        Console.WriteLine("Current User Score: {0}", score);
        Console.WriteLine("Питання 4, яку страву найбільше у світі любить ведмежа Паддінгтон?");
        Console.WriteLine("1.Мед");
        Console.WriteLine("2.Мармелад із апельсинів");
        Console.WriteLine("3.Шоколадний торт");
        Console.WriteLine("4.Печиво з молоком");
        Console.WriteLine();
        int answer4 = int.Parse(Console.ReadLine());
        if (answer4 == 2)
        {
            score += 100;
            Console.WriteLine("Correct answer");
        }
        else
        {
            Console.WriteLine("Wrong Answer");
            Console.WriteLine("кінець програми.");
            return;
        }
        Console.WriteLine();
        Console.WriteLine("Current User Score: {0}", score);
        Console.WriteLine("Питання 5, що створює головний герой Віллі Вонка у своїй чарівній майстерні?");
        Console.WriteLine("1.Іграшки");
        Console.WriteLine("2.Шоколад і солодощі");
        Console.WriteLine("3.Парфуми");
        Console.WriteLine("4.Музичні інструменти");
        Console.WriteLine();
        int answer5 = int.Parse(Console.ReadLine());
        if (answer5 == 2)
        {
            score += 100;
            Console.WriteLine("Correct answer");
            Console.WriteLine("\nВітаємо! Ви виграли! Фінальний рахунок: {0}", score);
        }
        else
        {
            Console.WriteLine("Wrong Answer");
            Console.WriteLine("кінець програми.");
            return;
        }
    }
}