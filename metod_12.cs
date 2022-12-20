using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace metod_12
{
    internal class Program
    {
        static void Delta(int[] nums)
        {
            List<int> list = new List<int>();
            list.Add(nums[0]);

            for(int i = 1; i < nums.Length; i++)
                list.Add(nums[i] - nums[i - 1]);

            foreach(int i in list)
                Console.Write(i + "  ");
        }

        static void Main(string[] args)
        {
            int[] nums = new int[7] { -5, 14, 2, 74, 10, 0, 61 };
            Delta(nums);
        }
    }
}
