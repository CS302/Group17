using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[3];
            workers[0] = new Worker("John", 27, 68153);
            workers[1] =new Worker("Tony", 25, 486551);
            workers[2] = new Worker("Svetlana", 23);
            
            Worker.PrintWorkers(workers);
            Console.WriteLine("---------");
            Console.WriteLine(Worker.count);
        }
        //...
    }

    class Worker
    {
        /// <summary>
        /// Имя
        /// </summary>
        private string name;
        /// <summary>
        /// Возраст
        /// </summary>
        private int age;
        /// <summary>
        /// ИНН
        /// </summary>
        public int snn;
        public static int count;

        public int Age
        {
            set 
            {
                if (value <= 0)
                    Console.WriteLine("Неверно задан возраст!!!");
                else
                    age = value;
            }
            get { return age; }
        }
        public string Name
        {
            get;    set;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        /// <param name="snn">ИНН</param>
        public Worker(string name, int age, int snn)
        {
            this.name = name;
            Age = age;
            this.snn = snn;
            count++;
        }

        public Worker(string name, int age)
            : this(name, age, 0)
        {   }
        
        static Worker()
        {
            count = 0;
        }

        public void SetAge(int a)
        {
            if (a <= 0)
            {
                Console.WriteLine("Возраст задан неверно!!!");
            }
            else
            {
                age = a;
            }
        }
        public int GetAge()
        {
            return age;
        }
        public void Print()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("ИНН: " + snn);
            Console.WriteLine();
        }

        public static void PrintWorkers(Worker[] workers)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].Print();
            }
        }
    }
}
