using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            string[] char_nums = nums.Split(' ');
            List<int> nums_Betw_zero = new List<int>();

            bool start = true, end = true;
            int ind_First_Zero = 0, ind_Last_Zero = 0;
            for (int i = 0; i < char_nums.Length; i++)
            { //поиск первого и последнего нуля
                if (start)
                {
                    if (char_nums[i] == "0") 
                        start = false; 
                    ind_First_Zero = i; 
                }
                else if (end)
                {
                    if (char_nums[i] == "0")
                        end = false; 
                    ind_Last_Zero = i;
                } 
            }
            for (int i = ind_First_Zero + 1; i < ind_Last_Zero; i++) 
                nums_Betw_zero.Add(int.Parse(char_nums[i])); //добавление чисел между нулями в Список

            nums_Betw_zero.Sort();
            nums_Betw_zero.Reverse();

            foreach (var num in nums_Betw_zero) //вывод чисел
                Console.WriteLine(num);
        }
    }
}
