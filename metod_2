using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Factorize(int num)
        {
            for (int i = 1; i <= Math.Sqrt(num); i++)
                if (num % i == 0)
                    Console.WriteLine($"{num} = {i} * {num / i}");
        }

        static void Main()
        {
            int num = 100;
            Factorize(num);
        }
    }
}
