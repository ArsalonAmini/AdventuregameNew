using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NewAdventure
    {
        Player player; //create a variable to house an instance of the player class (player object)

        public NewAdventure(Player player) //constructor //Player uppercase is datatype(class) , player lowercase is local object (player)
        {
            this.player = player;
        }
        public void newAdventure() //method, new adventure
        {
            Console.WriteLine("Your adventure is over {0}, enter your next destination (city, town, bookstore, nightclub): ?");

            Console.ReadKey();
        }
    }
}
