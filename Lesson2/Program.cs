using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowArrays();
            //ShowRefTypes();

            //IfSwitch();
            /*for (int i = 0; i < 11 ; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }*/

            int[] mass = new int[5] { 11, 22, 33, 44, 55 };
            //min & max
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                Console.WriteLine(mass[i]);
            }

            /*int[,] table = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < table.GetLength(0) ; i++)
            {
                for (int j = 0; j < table.GetLength(1) ; j++)
                {
                    
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }*/

            /*string text = Console.ReadLine();
            while (text != "exit")
            {
                Console.WriteLine("Приложение работает");
                text = Console.ReadLine();
            }*/
            // yes/no
            string text;
            do
            {
                Console.WriteLine("Выполняется работа");
                text = Console.ReadLine();
            } while (text != "exit");
        }

        private static void IfSwitch()
        {
            string text = Console.ReadLine();
            /*if (text == "exit")
            {
                Console.WriteLine("Приложение закрыто");
            }
            else 
            {
                Console.WriteLine("Продолжаем работать");
            }*/
            switch (text) //только сылочный тип
            {
                case "exit":
                    Console.WriteLine("Закрыть");
                    break;
                case "option1":
                    Console.WriteLine("Включена настройка");
                    break;
                case "option2":
                case "option3":
                    Console.WriteLine("Включено еще что-то");
                    break;
                default:
                    Console.WriteLine("Приложение работает в штатном режиме");
                    break;
            }
        }

        static void ShowRefTypes()
        {
            int[] array1 = new int[2] { 5, 5 };
            int[] array2 = new int[2] { 9, 9 };

            Console.WriteLine(array1[0] + " " + array1[1]);
            Console.WriteLine(array2[0] + " " + array2[1]);
            Console.WriteLine("-----------");

            array1 = array2;
            Console.WriteLine(array1[0] + " " + array1[1]);
            Console.WriteLine(array2[0] + " " + array2[1]);
            Console.WriteLine("-----------");

            array2[0] = 100;
            array2[1] = 100;
            Console.WriteLine(array1[0] + " " + array1[1]);
            Console.WriteLine(array2[0] + " " + array2[1]);
            Console.WriteLine("-----------");
        }

        static void ShowArrays()
        {
            /*int num1 = CalculateSmth(10, 15);
            Console.WriteLine(num1);
            int x = 150;
            int y = 200;
            int num2 = CalculateSmth(x, y);

            int a = 100;
            int b = 350;
            int num3 = CalculateSmth(a, b);*/

            int[] numbers = new int[5] { 11, 22, 33, 44, 55 };
            /*numbers[0] = 11;
            numbers[1] = 22;
            numbers[2] = 33;
            numbers[3] = 44;
            numbers[4] = 55;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);*/
            Console.WriteLine("------------");
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.GetLength(0));

            Console.WriteLine("**********");

            int[,] table = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            /*table[0, 0] = 1;
            table[0, 1] = 2;
            table[0, 2] = 3;
            table[1, 0] = 4;
            table[1, 1] = 5;
            table[1, 2] = 6;

            Console.Write(table[0, 0] + " ");
            Console.Write(table[0, 1] + " ");
            Console.WriteLine(table[0, 2]);
            Console.Write(table[1, 0] + " ");
            Console.Write(table[1, 1] + " ");
            Console.WriteLine(table[1, 2]);*/
            Console.WriteLine("------------------");
            Console.WriteLine(table.Length); //6
            Console.WriteLine(table.GetLength(0)); //2 строки
            Console.WriteLine(table.GetLength(1)); //3 столбца

            int[][] table1 = new int[3][];
            table1[0] = new int[4];
            table1[1] = new int[2];
            table1[2] = new int[3];

            table1[0][0] = 1;
            table1[0][1] = 2;
            table1[0][2] = 3;
            table1[0][3] = 4;

            table1[1][0] = 5;
            table1[1][1] = 6;

            table1[2][0] = 7;
            table1[2][1] = 8;
            table1[2][2] = 9;

            Console.WriteLine(table1[0][0] + " " + table1[0][1] + " " + table1[0][2] + " " + table1[0][3]);
            Console.WriteLine(table1[1][0] + " " + table1[1][1]);
            Console.WriteLine(table1[2][0] + " " + table1[2][1] + " " + table1[2][2]);
        }

        static void DoSmth()
        {
            Console.WriteLine("Что-то произошло");
        }

        static int CalculateSmth(int a, int b)
        {
            return a + b; //завершает работу метода
        }
    }
}
