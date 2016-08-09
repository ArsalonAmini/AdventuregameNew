using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Player
    {
        //declaring variables
        string name;
        int score;
        
        public Player(string name)//constructor
        {
            this.name = name;   
        }
        public string getName()
        {
            return this.name;
        }
        public void changeName(string name)
        {
            this.name = name;
        }
       
       }
    }
