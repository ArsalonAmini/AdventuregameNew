using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AdventureGame
    {
        //declare variable
        private int numberOfRounds;
        private Player player;
        private int round;
        //constructor
        public AdventureGame() //constructor
        {
            this.player = new Player("Arsalon");        
            this.numberOfRounds = 3;
            this.round = 1;
        }

        public void RunGame() //method for running the adventuregame
        {
            Console.WriteLine("So you think you're adventurous? We'll see");
            while (this.round < this.numberOfRounds) //adventure loop
            {
                NextAdventure playerAdventure = new NextAdventure(player); //pass player object through NextAdventure class
                playerAdventure.ChooseAdventure();
                Console.WriteLine("Did you have fun?{0}", this.player.getName());
                this.round++;
            }
        }
    }

}

