using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace features_1
{
    public class Tree
    {
        private string treeType;
        private int height;

        public Tree(string treeType, int height) { 
            if(height > 0) { this.treeType= treeType; this.height = height;}
            else { throw new Exception("Высота меньше или равна 0 (height <= 0)\n"); }
        }
        public void Print() { Console.WriteLine(treeType + " " + height); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var tree1 = new Tree("сосна", 1);
            var tree2 = new Tree("береза", 80);
            tree2.Print();
        }
    }
}
