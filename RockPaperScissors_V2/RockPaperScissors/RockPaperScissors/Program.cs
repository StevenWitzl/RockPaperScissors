using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string comp = null;
            string player;
            int randomInt;
            int numberOfRounds;
            bool play;

            // ask user how many times they want to play and make sure its between 1-10

            while (true)
            {
                Console.Write("How many rounds would you like to play (between 1 and 10)?");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numberOfRounds))
                {
                    
                    if (numberOfRounds <= 10 && numberOfRounds >= 1)
                    {
                        play = true;
                        Console.Clear();
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Number of rounds has to be between 1 and 10!");
                    }
                }
                else
                {
                    Console.WriteLine("That was not a number!");
                }
            }

            while (play)
            {
                
                int pWins = 0;
                int cWins = 0;
                int ties = 0;

                for (int i = 1; i <= numberOfRounds; i++)
                {
                    //make sure they choose rock, paper, or scissor
                    while (true)
                    {
                        Console.Write("Choose between ROCK, PAPER and SCISSORS:    ");
                        player = Console.ReadLine().Trim();
                        player = player.ToUpper();

                        if (
                            player.ToUpper() == "ROCK" ||
                            player.ToUpper() == "PAPER" ||
                            player.ToUpper() == "SCISSORS"
                            )
                        {
                            break;
                        }

                    }
                    
                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    //compare player vs computer
                    switch (randomInt)
                    {
                        case 1:
                            comp = "ROCK";
                            break;
                        case 2:
                            comp = "PAPER";
                            break;
                        case 3:
                            comp = "SCISSORS";
                            break;
                    }

                    if (player == "ROCK" && comp == "SCISSORS" ||
                        player == "SCISSORS" && comp == "PAPER" ||
                        player == "PAPER" && comp == "ROCK")  //player wins
                    {
                        Console.WriteLine("PLAYER WINS!!\n");
                        pWins++;
                    }
                    else if (player != comp) //comp wins
                    {
                        Console.WriteLine("CPU WINS!!\n");
                        cWins++;
                    }
                    else //draw
                    {
                        Console.WriteLine("DRAW!!\n");
                        ties++;
                    }

                }
                //show score
                Console.WriteLine("You had a score of " + pWins);
                Console.WriteLine("The computer had a score of " + cWins);
                Console.WriteLine("You tied a total of " + ties + " times\n");

                if (pWins > cWins)
                {
                    Console.WriteLine("You won! with a score of " + pWins);
                }
                else if(pWins < cWins)
                {
                    Console.WriteLine("The computer won! with a score of " + cWins);
                }
                else
                {
                    Console.WriteLine("You Tied!");
                }

                //see if they want to play again
                Console.WriteLine("Do you want to play again?(Y/N)");
                string loop = Console.ReadLine();
                loop = loop.ToUpper();
                if (loop == "Y")
                {
                    play = true;
                    Console.Clear();
                }
                else
                {
                    play = false;
                }
            }
        }
    }
}
 

        