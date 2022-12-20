using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod_13
{
    internal class Program
    {
        static void DeltaDecoding(int[] nums)
        {
            List<int> list = new List<int>();
            list.Add(nums[0]);

            for (int i = 1; i < nums.Length; i++)
                list.Add(nums[i] + list[i-1]);

            foreach (int i in list)
                Console.Write(i + "  ");
        }

        static void Main(string[] args)
        {
            int[] n = new int[] { 8, 25, -48, 15, 19, -36 };
            DeltaDecoding(n);
        }
    }
}
