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
            string inputCPU;
            string playerInput;
            int randomInt;
            int numberOfRounds;

            bool play;

            // ask user how many times they want to play and make sure its between 1-10
            Console.Write("How many rounds would you like to play (between 1 and 10)?");
            numberOfRounds = int.Parse(Console.ReadLine());
            if (numberOfRounds <= 10 && numberOfRounds >= 1)
            {
                play = true;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Number of rounds has to be between 1 and 10!");
                Console.ReadLine();
                play = false;
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
                        playerInput = Console.ReadLine().Trim();
                        playerInput = playerInput.ToUpper();

                        if (
                            playerInput.ToUpper() == "ROCK" ||
                            playerInput.ToUpper() == "PAPER" ||
                            playerInput.ToUpper() == "SCISSORS"
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
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (playerInput == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n");
                                ties++;
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n");
                                pWins++;
                            }
                            else if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n");
                                cWins++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (playerInput == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n");
                                ties++;
                            }
                            else if (playerInput == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n");
                                cWins++;
                            }
                            else if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!\n");
                                pWins++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n");
                                ties++;
                            }
                            else if (playerInput == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n");
                                pWins++;
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n");
                                cWins++;
                            }
                            break;
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
                else 
                {
                    Console.WriteLine("The computer won! with a score of " + cWins);
                }

                //see if they want to play again
                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    play = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    play = false;
                }
                else if (loop != "y" || loop != "n")
                {
                    play = false;
                }
            }
        }
    }
}
 

        