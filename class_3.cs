using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Coord
    {
        public int x, y, z;
        public Coord(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public bool is_Sleeping() { return (y == 0); }
    }
    internal class Program
    {
        //Расстояние по прямой
        static double Distance(Coord fly, Coord spider)
        {
            return Math.Round(Math.Sqrt(Math.Pow(fly.x + spider.x, 2) + Math.Pow(fly.y + spider.y, 2) + Math.Pow(fly.z + spider.z, 2)), 5);
        }
        //Путь до мухи
        static double Spider_way(Coord fly, Coord spider)
        {
            return Math.Round(Math.Abs(fly.y - spider.y) + Math.Sqrt(Math.Pow(fly.x + spider.x, 2) + Math.Pow(fly.z + spider.z, 2)), 5);
        }
        static void Main()
        {
            var fly = new Coord(1, 0, 4);
            var spider = new Coord(6, 12, 42);

            if (fly.is_Sleeping())
            {
                Console.WriteLine(Distance(fly, spider));
                Console.WriteLine(Spider_way(fly, spider));
            }
        }
    }
}
