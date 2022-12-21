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
        static int[] GetCubes(int st, int end)
        {
            int[] massiv = new int[end - st + 1];
            for (int i = st, id = 0; i <= end; i++, id++)
                massiv[id] = (int)Math.Pow(i, 3);

            return massiv;
        }
        /*
        Введите a: 5
        Введите b: 10
        2925
         */
        static void PrintSum(int[] massiv)
        {
            int sum = 0;
            for (int i = 0; i < massiv.Length; i++)
                sum += massiv[i];

            Console.WriteLine(sum);
        }

        static void Main()
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            PrintSum(GetCubes(a, b));
        }
    }
}
