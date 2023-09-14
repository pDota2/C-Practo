using System;
using System.Xml;

namespace calculator13
{
    internal class Program
    {
        static void Main(string[] a)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите номер операции которую необходимо выполнить:");
            Console.ResetColor();
            Console.WriteLine("[1]Сложить\n[2]Вычесть\n[3]Перемножить\n[4]Разделить\n[5]Возвести с степень n\n[6]Найти квадратный корень\n[7]Найти 1%\n[8]Найти факториал");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[9] Выход");
            Console.ResetColor();
            double num = Convert.ToDouble(Console.ReadLine());
            double number1;
            double number2;
            double numS = 0;
            while (num != 9)
            {
                bool Error = false;
                if (num == 1)
                {
                    Console.WriteLine("Введите первое число:");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    numS = (number1 + number2);
                }
                else if (num == 2)
                {
                    Console.WriteLine("Введите первое число:");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    numS = (number1 - number2);
                }
                else if (num == 3)
                {
                    Console.WriteLine("Введите первое число:");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    numS = (number1 * number2);
                }
                else if (num == 4)
                {
                    Console.WriteLine("Введите первое число:");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    if (number2 != 0)
                    {
                        numS = (number1 / number2);
                    }
                    else
                    {
                        numS = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("На нуль делить нельзя");
                        Error = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Введите номер операции которую необходимо выполнить:");
                        Console.ResetColor();
                    }
                }
                else if (num == 5)
                {
                    Console.WriteLine("Введите первое число:");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    numS = Math.Pow(number1, number2);
                }
                else if (num == 6)
                {
                    Console.WriteLine("Введите первое число:");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    numS = Math.Sqrt(number1);
                }
                else if (num == 7)
                {
                    Console.WriteLine("Введите первое число:");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    numS = (number1 / 100);
                }
                else if (num == 8)
                {
                    Console.WriteLine("Введите первое число:");
                    number1 = Convert.ToDouble(Console.ReadLine()); ;
                    int g = 1;
                    for (int i = 1; number1 >= i; ++i)
                    {
                        g = g * i;
                    }
                    numS = g;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Необходимо ввести номер операции которую необходимо выполнить:");
                    Console.ResetColor();
                    Error = true;
                }

                if (!Error)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ответ:" + numS);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Введите номер операции которую необходимо выполнить:");
                    Console.ResetColor();
                }
                num = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
        } //switch + case = скучно...
    }
}