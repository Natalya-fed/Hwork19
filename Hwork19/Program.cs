using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computersList = new List<Computer>()
            {
                new Computer(){ Name = "MSI", TypeCPU = "Core i7", FreqCPU = 2.3, RAM = 32, HDD = 500, GPU = 8, Price = 35000, Availability = 10 },
                new Computer(){ Name = "Asus", TypeCPU = "Core i5", FreqCPU = 2.9, RAM = 8, HDD = 512, GPU = 8, Price = 25500, Availability = 57 },
                new Computer(){ Name = "Lenovo", TypeCPU = "Core i3", FreqCPU = 3.4, RAM = 16, HDD = 1000, GPU = 4, Price = 23000, Availability = 23 },
                new Computer(){ Name = "HP", TypeCPU = "Core i7", FreqCPU = 3.4, RAM = 16, HDD = 512, GPU = 16, Price = 45000, Availability = 5 },
                new Computer(){ Name = "Asus", TypeCPU = "Core i7", FreqCPU = 3.4, RAM = 32, HDD = 2000, GPU = 8, Price = 50000, Availability = 28 },
                new Computer(){ Name = "Huawei", TypeCPU = "Ryzen 7", FreqCPU = 3.6, RAM = 16, HDD = 1000, GPU = 4, Price = 55000, Availability = 7 },
                new Computer(){ Name = "Apple", TypeCPU = "Core i9", FreqCPU = 3.2, RAM = 32, HDD = 2000, GPU = 8, Price = 120000, Availability = 2 },
                new Computer(){ Name = "Asus", TypeCPU = "Ryzen 5", FreqCPU = 3.4, RAM = 8, HDD = 512, GPU = 8, Price = 30000, Availability = 16 }
            };
            Console.Write("Выберите тип процессора: ");
            string inputCPU = Console.ReadLine();
            List<Computer> cpu = computersList
                .Where(d => d.TypeCPU == inputCPU)
                .DefaultIfEmpty()
                .ToList();
            foreach (Computer d in cpu)
                if (d != null)
                {
                    Console.WriteLine($"{d.Name}, {d.Price} руб., {d.Availability} шт.");
                }
                else
                {
                    Console.WriteLine("Таких компьютеров нет");
                }
            Console.WriteLine();
            Console.Write("Укажите объем ОЗУ: ");
            int inputRam = Convert.ToInt32(Console.ReadLine());
            List<Computer> ram = computersList
                .Where(d => d.RAM >= inputRam)
                .DefaultIfEmpty()
                .ToList();
            foreach (Computer d in ram)
                if (d != null)
                {
                    Console.WriteLine($"{d.Name}, {d.RAM} ГБ, {d.Price} руб., {d.Availability} шт.");
                }
                else
                {
                    Console.WriteLine("Таких компьютеров нет");
                }
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Cортировка по цене: ");
            List<Computer> computersPrice = computersList
                .OrderBy(d => d.Price)
                .ToList();
            foreach (Computer d in computersPrice)
                Console.WriteLine($"{d.Name}, {d.Price}");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Сортировка по типу процессора: ");
            List<Computer> typeCPU = computersList
                .OrderBy(d => d.TypeCPU)
                .ToList();
            foreach (Computer d in typeCPU)
                Console.WriteLine($"{d.Name}, {d.TypeCPU}");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Самый дорогой компьютер.");
            Computer maxPrice = computersList
                .OrderByDescending(d => d.Price)
                .First();
            Console.WriteLine($"{maxPrice.Name} - {maxPrice.Price} руб.");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Самый бюджетный компьютер.");
            Computer minPrice = computersList
                .OrderBy(d => d.Price)
                .First();
            Console.WriteLine($"{minPrice.Name} - {minPrice.Price} руб.");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Есть ли хотя бы один компьютер в количестве не менее 30 штук: ");
            var computers30 = computersList
                .Any((d => d.Availability >= 30));
            if (computers30 == true)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
            Console.ReadKey();
        }
        class Computer
        {
            public string Name { get; set; }
            public string TypeCPU { get; set; }
            public double FreqCPU { get; set; }
            public int RAM { get; set; }
            public int HDD { get; set; }
            public int GPU { get; set; }
            public double Price { get; set; }
            public int Availability { get; set; }

        }
    }
}
