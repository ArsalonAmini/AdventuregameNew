using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            AdventureGame adventureGame = new AdventureGame(); //creating a new object
            adventureGame.RunGame();
            Console.WriteLine("I hope you had fun, enjoy your pleasure again soon!!");
            Console.ReadLine();

        }
    }
}
