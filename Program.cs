using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Some Kinda Text Adventure Thing");
            Console.WriteLine("By Me, Carson MacIntosh <- that's me :)");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("New Game     Save    Load");
            Console.WriteLine("--------------------------------------------");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You wake up 7 o'clock you need to be at work by 9");
            Console.WriteLine("Do you get out of bed?");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Yes     No");
            Console.WriteLine("Save     Load");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
