using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Player
    {
        //member variables
        public string name;
        public int score = 0;
        //constructor
        public Player()
        {
            
        }
        
    
        //methods 


       //get choice from user 
       public virtual int UserInput()
        {
            Console.WriteLine(name + " Please enter your weapon");
            Console.WriteLine("Enter 0 for Rock");
            Console.WriteLine("Enter 1 for Paper");
            Console.WriteLine("Enter 2 for Scissors");
            Console.WriteLine("Enter 3 for Lizard");
            Console.WriteLine("Enter 4 for Spock\n");

            int weapon = Convert.ToInt32(Console.ReadLine());
            return weapon;
        }

        //switch case for weapon options

       //get choice from AI- Random
       
    }
}
