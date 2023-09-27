using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число (1-31) в январе: ");
        if (int.TryParse(Console.ReadLine(), out int day) && day >= 1 && day <= 31)
        {
            int S = 1;
            int n = (S + day - 1) % 7; 

            switch (n)
            {
                case 0:
                    Console.WriteLine( "Воскресенье");
                    break;
                case 1:
                     Console.WriteLine( "Понедельник");
                    break;
                case 2:
                    Console.WriteLine( "Вторник");
                    break;
                case 3:
                    Console.WriteLine( "Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine( "Пятница");
                    break;
                case 6:
                    Console.WriteLine ( "Суббота");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Некорректное число. Введите число от 1 до 31.");
        }
        Console.WriteLine("Если хотите повторить ввод, введите 1, иначе любую другую цифру.");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a == 1)
        {
            Main();
        }

    }
}