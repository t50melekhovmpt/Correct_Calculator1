using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hulk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, n, r, h;
            /*double p = 9;*/
            int f = 1;
            /*while (true)*/
            {
                /*Console.WriteLine("Для начала работы нажмите любую ЦИФРУ. Если хотите завершить работу, нажмите 9\n");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine();*/
                do
                {
                    Console.WriteLine("Выберите операцию: \n1 - Сложение\n2 - Вычитание\n3 - Умножение\n4 - Деление\n5 - Возведение в степень\n6 - Квадратный корень от первого числа\n7 - Один процент от числа\n8 - Факториал от числа\n9 - Конец работы\n");
                    h = double.Parse(Console.ReadLine());
                    if (h == 9)
                        break;
                    else
                        Console.WriteLine("Введите первое число");
                    y = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    z = double.Parse(Console.ReadLine());
                    switch (h)
                    {
                        case 1:
                            Console.WriteLine(y + z + " Результат сложения\n");
                            break;
                        case 2:
                            Console.WriteLine(y - z + " Результат вычитания\n");
                            break;
                        case 3:
                            Console.WriteLine(y * z + " Результат умножения\n");
                            break;
                        case 4:
                            if (z == 0)
                                Console.WriteLine("Делить на ноль нельзя\n");
                            else
                                Console.WriteLine(y / z + " Результат деления\n");
                            break;
                        case 5:
                            Console.WriteLine("Первое число будет возведено в степень N\n");
                            Console.WriteLine("Введите N");
                            n = double.Parse(Console.ReadLine());
                            r = Math.Pow(y, n);
                            Console.WriteLine(r + " Результат возведения в степень\n");
                            break;
                        case 6:
                            r = Math.Pow(y, 0.5);
                            Console.WriteLine(r + " Результат нахождения квадратного корня\n");
                            break;
                        case 7:
                            Console.WriteLine("Будет найден процент от первого числа, нажмите любую ЦИФРУ . Если хотите найти от второго, нажмите 2\n");
                            r = double.Parse(Console.ReadLine());
                            if (r == 2)
                                Console.WriteLine(z / 100 + " Результат нахождения одного процента от второго числа\n");
                            else
                                Console.WriteLine(y / 100 + " Результат нахождения одного процента от первого числа\n");
                            break;
                        case 8:
                            for (int i = 1; i <= y; i++)
                            {
                                f = f * i;
                            }
                            Console.WriteLine(f + " Результат нахождения факториала\n");
                            break;
                        case 9:
                            break;

                            /*case 9:
                           Console.WriteLine("Конец работы\n");
                           break;
                           */

                    }
                } while (h != 9);
            }

        }
    }
}
