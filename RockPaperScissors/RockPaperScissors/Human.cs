using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Human : Player
    {
        public Human()
        {
            Console.WriteLine("Enter your name!");
            name = Console.ReadLine();
        }
    }
}
 