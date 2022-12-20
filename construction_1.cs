using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Watch
{
    private string nameWatch, typeWatch;
    private decimal cost;
    public Watch(string nameWatch, string typeWatch, decimal cost)
    {
        this.nameWatch = nameWatch;
        this.typeWatch = typeWatch;
        this.cost = cost;
    }

    public void Print() { Console.WriteLine(nameWatch + " " + typeWatch + " " + cost); }
}

namespace construction_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myWatch = new Watch("Casio", "electronic", 15.99M);
            myWatch.Print();
        }
    }
}
