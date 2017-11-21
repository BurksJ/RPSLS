using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class AI : Player
    {
        public AI()
        {
            name = "Computer";
        }
        public override int UserInput()
        {
            Random num = new Random();
            int aiTurn = num.Next(0, 5);
            return aiTurn;
        }
    }
}
