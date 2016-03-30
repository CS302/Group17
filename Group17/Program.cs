using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int number; // объявление
            number = 10; //инициализация
            Console.WriteLine(number);
            number = 100;
            Console.WriteLine(number);
            int number2 = 150;
            Console.WriteLine(number2);

            number = 4613 + 94 * 486 - 41;
            Console.WriteLine(number);

            number = 10 - number;
            Console.WriteLine(number);

            number = 56 / 10;
            Console.WriteLine(number);

            number = 56 % 10;
            Console.WriteLine(number);
            Console.WriteLine("***********");
            number = 56;
            double price = (double)number / 10;
            Console.WriteLine(price);*/

            string text = "78654";
            int number = int.Parse(text);
            number = number + 111;
            Console.WriteLine("Значение переменной = " + number);

            Console.WriteLine("a" + "b" + "c");

            char symbol = 'a';
            Console.WriteLine((int)'0');

            bool flag = true;
            flag = true && false;
            Console.WriteLine(flag);

            flag = !true; //отрицание
            Console.WriteLine(flag);

            int x = -0;

            number = 5;
            number++; //number = number + 1;
            Console.WriteLine(number);

            number += 5; //number = number + 5;
            Console.WriteLine(number);

            DateTime date = new DateTime(2016, 3, 30, 19, 37, 0);
            Console.WriteLine(date.Day);
            Console.WriteLine(date.DayOfWeek);
            Console.WriteLine(date.Month);
            DateTime date1 = DateTime.Now;
            Console.WriteLine(date1 - date);

            DayOfWeek day = DayOfWeek.Friday;
            number = (int)day;
            Console.WriteLine(number); //5

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Жёлтенький");

        }
    }
}
