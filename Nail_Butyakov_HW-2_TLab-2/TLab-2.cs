using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Лабораторная 2\n\nУпражнение 2.1 Приветствие по имени\nВведите ваше имя:");
                Console.WriteLine($"Привет, {Console.ReadLine()}");
            }
            {
                Console.Write("\nУпражнение 2.2 Деление целых чисел\nВведите первое целое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе целое число: ");
                int b = Convert.ToInt32(Console.ReadLine());

                try
                {
                    double c = a / b;
                    Console.WriteLine($"Результат деления чисел: {(double)a / b}");

                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка, на ноль делить нельзя!");
                }
            }
            {
                Console.Write("\nДомашнее задание 2.1 вывод следующей буквы в алфавите\nВведите строчную латинскую букву: ");
                char[] alph = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                char lett = Console.ReadLine()[0];
                if (lett == 'z')
                {
                    Console.WriteLine("Следующая буква: a");
                }
                else
                {
                    for (int i = 0; i < alph.Length; i++)
                    {
                        if (lett == alph[i])
                        {
                            Console.WriteLine($"Следующая буква: {alph[i + 1]}");
                        }
                    }
                }
            }
            {
                Console.WriteLine("\nДомашнее задание 2.2 Решение квадратного уравнения");
                Console.Write("Введите коэффциенты a b c квадратного уравнения\nВведите a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите с: ");
                double c = Convert.ToDouble(Console.ReadLine());
                double D = b * b - 4 * a * c;
                if (D == 0)
                {
                    double x = (b * (-1)) / (2 * a);
                    Console.WriteLine($"Корень уравнения x = {x}");
                }
                if (D > 0)
                {
                    double x1 = (b * (-1) + Math.Sqrt(D)) / (2 * a);
                    double x2 = (b * (-1) - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine($"Корни уравнения x1 = {x1}, x2 = {x2}");
                }
                if (D < 0)
                {
                    Console.WriteLine("Нет корней");
                }
            }
        }
    }
}