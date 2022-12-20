using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            str = new string(str.Where(c => !char.IsPunctuation(c)).ToArray());
            string[] str_split = str.Split(' ');

            Console.WriteLine(str_split[0] + " " + str_split[1] + ", " + str_split[2] + "!");
        }
    }
}
