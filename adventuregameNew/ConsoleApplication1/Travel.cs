using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //declare variables
    string choice;

    public Travel(string choice) //constructor
    {
        this.choice = choice;
        Console.WriteLine("Let us begin {0}", this.choice);
    }

    public string ChooseAdventure() //method for adventuring
    {
        switch (choice);
        {
                    case "City":
                        Console.WriteLine("Enjoy" + city);
            break;
                    case "Town":
                        Console.WriteLine("Welcome" + town);
            break;
                    case "bookstore":
                        Console.WriteLine("Enjoy" + bookstore);
            break;
                    case "nightclub":
                        Console.WriteLine("Welcome" + nightclub);
            break;
            default:
                        Console.WriteLine("Looks like you would rather stay at home than adventure");
            break;
        }





    }
}