using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersLibrary
{
    interface IPayTax
    {
        double PayTax();
    }

    public abstract class Worker
    {
        private string name; //поле класса
        private int age;
        public int snn;
        public static int count; //поле count относится не к объекту-работнику, а к классу
        protected double salary;

        public int Snn
        {
            get {return snn;} 
            set {snn = value;} 
        }
        public int Age
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Неверно задан возраст!!!");
                }
                else
                {
                    age = value;
                }
            }
            get
            {
                return age;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        static Worker()
        {
            count = 0;
        }

        public Worker(string name, int age, int snn)
        {//главный конструктор
            this.name = name;
            Age = age;
            this.snn = snn;
            count++;
            salary = 30000;
        }

        public Worker(string name, int age)
            : this(name, age, 0) //второстепенный конструктор
        { }

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

        abstract public double GetBonus();
        public virtual void Print() //метод
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("ИНН: " + snn);
            Console.WriteLine();
        }
    }

    public class Manager : Worker, IPayTax
    {
        private int projCount;

        public int ProjCount
        {
            get { return projCount; }
            set { projCount = value; }
        }

        public Manager(string name, int age, int snn, int projCount)
            : base(name, age, snn)
        {
            this.projCount = projCount;
            salary = 70000;
        }

        public override double GetBonus()
        {
            return projCount * 1500;
        }

        public double PayTax()
        {
            return salary * 0.13;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Проектов: " + projCount);
            Console.WriteLine();
        }
    }

    public sealed class Driver : Worker
    {
        private string carType;

        public string CarType
        {
            get { return carType; }
            set { carType = value; }
        }
        private int hours;

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public Driver(string name, int age, int snn, string carType, int hours)
            : base(name, age, snn)
        {
            this.carType = carType;
            this.hours = hours;
            salary = 50000;
        }

        public override double GetBonus()
        {
            return hours * 100;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Машина: " + carType);
            Console.WriteLine("Часы: " + hours);
            Console.WriteLine();
        }
    }
}

