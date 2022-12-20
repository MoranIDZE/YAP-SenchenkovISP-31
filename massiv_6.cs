using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { -5, 14, 2, 74, 10, 0, 61 };

            int len = array.Length; //сортировка
            for (var i = 1; i < len; i++)
                for (var j = 0; j < len - i; j++)
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }

            foreach(var i in array)
                Console.Write(i + "  ");
        }
    }
}
