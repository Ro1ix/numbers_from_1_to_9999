using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_to_9999
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число от 1 до 9999 включительно:");
            int money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if ((money < 1) || (money > 9999))
                Console.Write("!!! ОТ 1 ДО 9999 ЧЕЛ !!!");
            else
            {
                if ((money / 1000) == 1)
                    Console.Write("Одна тысяча ");
                else if ((money / 1000) == 2)
                    Console.Write("Две тысячи ");
                else if ((money / 1000) == 3)
                    Console.Write("Три тысячи ");
                else if ((money / 1000) == 4)
                    Console.Write("Четыре тысячи ");
                else if ((money / 1000) == 5)
                    Console.Write("Пять тысяч ");
                else if ((money / 1000) == 6)
                    Console.Write("Шесть тысяч ");
                else if ((money / 1000) == 7)
                    Console.Write("Семь тысяч ");
                else if ((money / 1000) == 8)
                    Console.Write("Восемь тысяч ");
                else if ((money / 1000) == 9)
                    Console.Write("Девять тысяч ");

                if ((money / 100) % 10 == 1)
                    Console.Write("сто ");
                else if ((money / 100) % 10 == 2)
                    Console.Write("двести ");
                else if ((money / 100) % 10 == 3)
                    Console.Write("триста ");
                else if ((money / 100) % 10 == 4)
                    Console.Write("четыреста ");
                else if ((money / 100) % 10 == 5)
                    Console.Write("пятьсот ");
                else if ((money / 100) % 10 == 6)
                    Console.Write("шестьсот ");
                else if ((money / 100) % 10 == 7)
                    Console.Write("семьсот ");
                else if ((money / 100) % 10 == 8)
                    Console.Write("восемьсот ");
                else if ((money / 100) % 10 == 9)
                    Console.Write("девятьсот ");

                if ((money / 10) % 10 == 1)
                {
                    if (money % 10 == 0)
                        Console.Write("десять рублей");
                    else if (money % 10 == 1)
                        Console.Write("одиннадцать рублей");
                    else if (money % 10 == 2)
                        Console.Write("двенадцать рублей");
                    else if (money % 10 == 3)
                        Console.Write("тринадцать рублей");
                    else if (money % 10 == 4)
                        Console.Write("четырнадцать рублей");
                    else if (money % 10 == 5)
                        Console.Write("пятнадцать рублей");
                    else if (money % 10 == 6)
                        Console.Write("шестнадцать рублей");
                    else if (money % 10 == 7)
                        Console.Write("семнадцать рублей");
                    else if (money % 10 == 8)
                        Console.Write("восемнадцать рублей");
                    else if (money % 10 == 9)
                        Console.Write("девятнадцать рублей");
                }
                else if ((money / 10) % 10 == 2)
                    Console.Write("двадцать ");
                else if ((money / 10) % 10 == 3)
                    Console.Write("тридцать ");
                else if ((money / 10) % 10 == 4)
                    Console.Write("сорок ");
                else if ((money / 10) % 10 == 5)
                    Console.Write("пятьдесят ");
                else if ((money / 10) % 10 == 6)
                    Console.Write("шестьдесят ");
                else if ((money / 10) % 10 == 7)
                    Console.Write("семьдесят ");
                else if ((money / 10) % 10 == 8)
                    Console.Write("восемьдесят ");
                else if ((money / 10) % 10 == 9)
                    Console.Write("девяносто ");

                if ((money / 10) % 10 != 1)
                {
                    if (money % 10 == 1)
                        Console.WriteLine("один рубль");
                    else if (money % 10 == 2)
                        Console.WriteLine("два рубля");
                    else if (money % 10 == 3)
                        Console.WriteLine("три рубля");
                    else if (money % 10 == 4)
                        Console.WriteLine("четыре рубля");
                    else if (money % 10 == 5)
                        Console.WriteLine("пять рублей");
                    else if (money % 10 == 6)
                        Console.WriteLine("шесть рублей");
                    else if (money % 10 == 7)
                        Console.WriteLine("семь рублей");
                    else if (money % 10 == 8)
                        Console.WriteLine("восемь рублей");
                    else if (money % 10 == 9)
                        Console.WriteLine("девять рублей");
                    else if (money % 10 == 0)
                        Console.WriteLine("рублей");
                };
            };
        }
    }
}
