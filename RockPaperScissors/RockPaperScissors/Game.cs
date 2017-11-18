using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        public void DisplayRules()
        {
            Console.WriteLine("This game is called, Rock,Paper, Scissors, Lizard, Spock.");
            Console.WriteLine("The winner is the one who defeats the others best 2 of 3 rounds.");
            Console.WriteLine("In a tie, the round is repeated until a winner is found.");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("Rock crushes Scissors\n");
        }

        public void GameMenu()
        {
            DisplayRules();
            Console.WriteLine("For player vs computer, enter 1");
            Console.WriteLine("For player vs player, enter 2.");
            string caseSwitch = Console.ReadLine();
            //switch (caseSwitch)
            //{
            //    case 1: //if player enters 1 then start player vs AI
            //        break;
            //    case 2: //if player enters 2 then start player vs player
            //        break;
            //    default:
            //        Console.WriteLine("Invalid entry, press 1 or 2.\n");
            //        GameMenu();
            //        break;
            //}  
        }
    }
}
