using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Worker
    {
        public string name, surname; // Имя : Фамилия
        public int rate, days; // Ставка : Отработанные дни

        public Worker(string name, string surname, int rate, int days)
        {
            this.name = name;
            this.surname = surname;
            this.rate = rate;
            this.days = days;
        }

        public void GetFullName() { Console.WriteLine($"Имя: {name} \nФамилия: {surname}"); }
        public int GetSalary() { return days * rate; }
    }
    internal class Program
    {
        static void Main()
        {
            Worker worker = new Worker("Илья", "Пупкин", 11, 200);
            worker.GetFullName();
            Console.WriteLine(worker.GetSalary());
        }
    }
}
