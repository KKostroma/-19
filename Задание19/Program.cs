using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание19
{
        class Computer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Processor { get; set; }
            public double Frequency { get; set; }
            public int RAM { get; set; }
            public int HDD { get; set; }
            public int VC { get; set; }
            public int Cost { get; set; }
            public int Number { get; set; }
        }

        static class Program
        {
            static void Main(string[] args)
            {
                List<Computer> listComputer = new List<Computer>()
                {
                    new Computer(){ Id = 1, Name = "MSI", Processor = "Corei5", Frequency = 4.3, RAM = 64, HDD = 512, VC = 6, Cost = 30000, Number = 20 },
                    new Computer(){ Id = 2, Name = "Lenovo", Processor = "Corei3", Frequency = 3.6, RAM = 32, HDD = 256, VC = 3, Cost = 15000, Number = 15 },
                    new Computer(){ Id = 3, Name = "HP", Processor = "Corei5", Frequency = 3.6, RAM = 64, HDD = 128, VC = 5, Cost = 25000, Number = 25 },
                    new Computer(){ Id = 4, Name = "Lenovo", Processor = "Corei7", Frequency = 4.3, RAM = 128, HDD = 512, VC = 8, Cost = 60000, Number = 40 },
                    new Computer(){ Id = 5, Name = "MSI", Processor = "Corei5", Frequency = 2.9, RAM = 32, HDD = 128, VC = 4, Cost = 20000, Number = 30 },
                };
            //1. все компьютеры с указанным процессором. Название процессора запросить у пользователя;
            Console.WriteLine("Введите название процессора");
            string pro = Console.ReadLine();
            List<Computer> comps1 = listComputer
               .Where(d => d.Processor == pro)
               .ToList();
               foreach (Computer d in comps1)
               Console.WriteLine($"{d.Id} {d.Name} {d.Processor} {d.Frequency} {d.RAM} {d.HDD} {d.VC} {d.Cost} {d.Number}");


            //2. все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
             Console.WriteLine("Введите объем оперативной памяти");
             int ram = Convert.ToInt32(Console.ReadLine());
             List<Computer> comps2 = listComputer
             .Where(d => d.RAM >= ram)
            .ToList();
                foreach (Computer d in comps2)
                Console.WriteLine($"{d.Id} {d.Name} {d.Processor} {d.Frequency} {d.RAM} {d.HDD} {d.VC} {d.Cost} {d.Number}");

            //3. вывести весь список, отсортированный по увеличению стоимости;
            Console.WriteLine("Список товаров по увеличению стоимости");
            List<Computer> comps3 = listComputer
            .OrderBy(d => d.Cost)
            .ToList();
            foreach (Computer d in comps3)
                Console.WriteLine($"{d.Id} {d.Name} {d.Processor} {d.Frequency} {d.RAM} {d.HDD} {d.VC} {d.Cost} {d.Number}");

            //4. вывести весь список, сгруппированный по типу процессора;
            Console.WriteLine("Список товаров, сгруппированный по типу процессора");
            List<IGrouping<string, Computer>> comps4 = listComputer
            .GroupBy(d => d.Processor)
            .ToList();
            foreach (IGrouping<string, Computer> d in comps4)
            {
                Console.WriteLine(d.Key);
                foreach(Computer d2 in d)
                {
                    Console.WriteLine($"{d2.Id} {d2.Name} {d2.Processor} {d2.Frequency} {d2.RAM} {d2.HDD} {d2.VC} {d2.Cost} {d2.Number}");
                }
            }


            //5. найти самый дорогой и самый бюджетный компьютер;
            Console.WriteLine("Самый дорогой компьютер");
            Computer listComputer5 = listComputer.OrderByDescending(d => d.Cost).FirstOrDefault();
            Console.WriteLine($"{listComputer5.Id} {listComputer5.Name} {listComputer5.Processor} {listComputer5.Frequency} {listComputer5.RAM} {listComputer5.HDD} {listComputer5.VC} {listComputer5.Cost} {listComputer5.Number}");

            Console.WriteLine("Самый бюджетный компьютер");
            Computer listComputer6 = listComputer.OrderByDescending(d => d.Cost).LastOrDefault();
            Console.WriteLine($"{listComputer6.Id} {listComputer6.Name} {listComputer6.Processor} {listComputer6.Frequency} {listComputer6.RAM} {listComputer6.HDD} {listComputer6.VC} {listComputer6.Cost} {listComputer6.Number}");

            //6. есть ли хотя бы один компьютер в количестве не менее 30 штук?
            Console.WriteLine("Есть ли компьютеры в количестве более 30 шт.?");

            listComputer.Any(d => d.Number > 30);
            
            if (listComputer.Any(d => d.Number > 30))
            {
                Console.WriteLine("Имеются");
            }
            else
                Console.WriteLine("Отсутствуют");


            Console.ReadKey();
            }
        }
    
}
