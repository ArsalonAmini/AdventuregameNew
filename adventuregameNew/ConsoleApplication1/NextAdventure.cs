using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NextAdventure
    {

        //declare variables
        string UserInput;
        private Player player;
        private NewAdventure newAdventure;


        public NextAdventure(Player player)
        {
            this.player = player;
        }

        public void ChooseAdventure() //method for chosing an adventure
        {
            Console.WriteLine("Enter an adventure (town, city, nightclub, bookstore):");
            string UserInput = Console.ReadLine();

            if (UserInput == "city")
            {
                Console.WriteLine("Enjoy the city {0}");
            }
            else if (UserInput == "town")
            {
                Console.WriteLine("Enjoy the town{0}");
            }
            else if (UserInput == "bookstore")
            {
                Console.WriteLine("you're a nerd, this is a problem {0}");
            }

            else if (UserInput == "nightclub")
            {
                Console.WriteLine("Party girl/boy? Enjoy yourself {0}");
            }
            else
            {
                Console.WriteLine("Looks like you would rather stay at home than adventure");
            }
        }
    }
}
