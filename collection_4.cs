using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_4
{
    internal class Program
    {
        static List<int> Siraqus(int num)
        {
            List<int> list = new List<int>() {num};
            int secNum = num;
            while (true)
            {
                if (secNum % 2 != 0 && secNum != 1)
                {
                    secNum = secNum * 3 + 1;
                    list.Add(secNum);
                }
                else if (secNum % 2 == 0)
                {
                    secNum /= 2;
                    list.Add(secNum);
                }
                if (secNum == 1)
                    break;
            }

            return list;
        }

        static void Main(string[] args)
        {
            List<int> list = Siraqus(3);

            foreach (var i in list)
                Console.WriteLine(i);
        }
    }
}
