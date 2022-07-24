using System;

namespace InterfacesDemo
{
    // SOLID -> I harfi, Interface Segregation (interfacelerin doğru planlanması)
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            ISalary[] salaries = new ISalary[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }
        }
    }
    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager eat.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager got paid.");
        }

        public void Work()
        {
            Console.WriteLine("Manager worked");
        }
    }
    class Worker : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            Console.WriteLine("Worker eat.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker got paid.");
        }

        public void Work()
        {
            Console.WriteLine("Worker worked");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot worked");
        }
    }
}
