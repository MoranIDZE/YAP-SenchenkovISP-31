using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symb = char.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(new string(symb, num));
        }
    }
}
