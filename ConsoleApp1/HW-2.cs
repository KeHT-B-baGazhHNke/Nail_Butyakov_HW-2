using System;
using System.Text.RegularExpressions;
using System.Threading;
namespace Nail_Butyakov_HW2
{
    struct user
    {
        public string name;
        public string city;
        public byte age;
        public int pin;
        public void Print()
        {
            Console.WriteLine($"\nИмя пользователя: :{name}\nГород: :{city}\nВозраст: :{age}\nPIN-код: :{pin}");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Задание 1 Типы данных\nbyte - Максимальное значение: 255, Минимальное значение: 0");
                Console.WriteLine("sbyte - Максимальное значение: 127, Минимальное значение: -128");
                Console.WriteLine("short - Максимальное значение: 32767, Минимальное значение: -32768");
                Console.WriteLine("ushort - Максимальное значение: 65535, Минимальное значение: 0");
                Console.WriteLine("int - Максимальное значение: 2147483647, Минимальное значение: -2147483648");
                Console.WriteLine("uint - Максимальное значение: 4294967295, Минимальное значение: 0");
                Console.WriteLine("long - Максимальное значение: 9223372036854775807, Минимальное значение: -922337203685477808");
                Console.WriteLine("ulong - Максимальное значение: 18446774073709551615, Минимальное значение: 0");
                Console.WriteLine("float - Максимальное значение: 3,402823e38, Минимальное значение: -3,402823e38");
                Console.WriteLine("double - Максимальное значение: 1,797693e308, Минимальное значение: -1,797693e308");
                Console.WriteLine("decimal - Максимальное значение: 7,992816e28, Минимальное значение: -7,992816e28");
            }
            {
                Console.WriteLine("\nЗадание 2 Данные пользователя");
                user person = new user();
                Console.WriteLine("Введите ваше имя: ");
                person.name = Console.ReadLine();
                Console.WriteLine("Введите ваш город: ");
                person.city = Console.ReadLine();
                Console.WriteLine("Введите ваш возраст: ");
                person.age = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Введите PIN: ");
                person.pin = Convert.ToInt32(Console.ReadLine());
                person.Print();
            }
            {
                Console.Write("\nЗадание 3 смена строчных букв на заглавные и наоборот\nВведите строку: ");
                string text = Console.ReadLine();
                string newtext = "";
                for (int i = 0; i < text.Length; i++)
                    if (text[i] == text.ToUpper()[i])
                    {
                        newtext += text.ToLower()[i];
                    }
                    else
                    {
                        newtext += text.ToUpper()[i];
                    }
                Console.WriteLine($"Преобразованная строка: :{newtext}");
            }
            {
                Console.Write("\nЗадание 4 смена количество вхождений строки в подстроку\nВведите строку: ");
                string s = Console.ReadLine();
                Console.Write("Введите подстроку: ");
                string s0 = Console.ReadLine();
                int count = new Regex(s0).Matches(s).Count;
                Console.WriteLine($"Кол-во вхождений строки в подстроку:{count}");
            }
            {
                Console.Write("\nЗадача 5 как окупить отпуск?\nВведите стандартную цену бутылки: ");
                int normPrice = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите скидку в Duty Free в процентах: ");
                int salePrice = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите стоимость отпуска: ");
                int holidayPrice = Convert.ToInt32(Console.ReadLine());
                int profit = (int)(holidayPrice / (normPrice - normPrice * (1 - salePrice * 0.01)));
                Console.WriteLine($"Чтобы окупить отпуск нужно купить {profit} бутылок");
            }
            {
                Console.WriteLine("\nЗадание 6 Воспроизведение разговора Гарри Поттера и дневника Тома Реддла\nПоздоровайся с дневником");
                Console.ReadLine();
                Console.WriteLine("Как тебя зовут?");
                string name = Console.ReadLine();
                Console.WriteLine($"Привет, {name}");
                Console.ReadLine();
                Console.WriteLine("Да");
                Console.ReadLine();
                Console.WriteLine("Нет");
                Thread.Sleep(5000);
                Console.WriteLine("Но могу показать");
                Thread.Sleep(1000);
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.Clear();
                Thread.Sleep(5000);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
            }
            {
                Console.WriteLine("Задание 7 вычислить контрольную цифру штрихкода (EAN13)\n12 цифр определяются случайным образом:");
                Random rnd = new Random();
                string rndbar = Convert.ToString(rnd.Next(10)) + Convert.ToString(rnd.Next(10)) + Convert.ToString(rnd.Next(10)) + Convert.ToString(rnd.Next(10)) + Convert.ToString(rnd.Next(10)) + Convert.ToString(rnd.Next(10)) + Convert.ToString(rnd.Next(10)) + Convert.ToString(rnd.Next(10)) + Convert.ToString(rnd.Next(10)) + Convert.ToString(rnd.Next(10)) + Convert.ToString(rnd.Next(10)) + Convert.ToString(rnd.Next(10));
                int cdgt = (Convert.ToInt32(rndbar[1]) + Convert.ToInt32(rndbar[3]) + Convert.ToInt32(rndbar[5]) + Convert.ToInt32(rndbar[7]) + Convert.ToInt32(rndbar[9]) + Convert.ToInt32(rndbar[11])) + 3 * (Convert.ToInt32(rndbar[0]) + Convert.ToInt32(rndbar[2]) + Convert.ToInt32(rndbar[4]) + Convert.ToInt32(rndbar[6]) + Convert.ToInt32(rndbar[8]) + Convert.ToInt32(rndbar[10]));
                int lnum = (10 - cdgt % 10) % 10;
                Console.WriteLine($"Штрих-код: {rndbar}, Контрольная цифра: {lnum}\n");
                Console.Write("12 цифр вводит пользователь:\nВведите слитно первые 12 цифр штрих-кода: ");
                string bar = Console.ReadLine();
                int cdgt1 = (Convert.ToInt32(bar[1]) + Convert.ToInt32(bar[3]) + Convert.ToInt32(bar[5]) + Convert.ToInt32(bar[7]) + Convert.ToInt32(bar[9]) + Convert.ToInt32(bar[11])) + 3 * (Convert.ToInt32(bar[0]) + Convert.ToInt32(bar[2]) + Convert.ToInt32(bar[4]) + Convert.ToInt32(bar[6]) + Convert.ToInt32(bar[8]) + Convert.ToInt32(bar[10]));
                int lnum1 = (10 - cdgt1 % 10) % 10;
                Console.WriteLine($"Штрих-код: {bar}, Контрольная цифра: {lnum1}\n");


            }
        }
    }
}