using System;

namespace Rock_Paer_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerInput;
            int randomNum;
            Console.WriteLine("Let us play Rock Paper Scissors.");
            Console.Write("OK, let's go. Rock, Paper, Scissor ? ");

            playerInput = Console.ReadLine();
            Random rnd = new Random();
            randomNum = rnd.Next(1, 4);

            if (playerInput != "Rock" && playerInput != "Paper" && playerInput != "Scissors")
            {
                Console.WriteLine("HUH! Please enter rock, paper or scissors");
            }
            else
            {
                switch (randomNum)
                {
                    case 1:
                        Console.WriteLine("Rock");
                        if (playerInput == "Rock")
                        {
                            Console.WriteLine("DRAW ");
                        }
                        else if (playerInput == "Paper")
                        {
                            Console.WriteLine("Paper you Loose");
                        }
                        else
                        {
                            Console.WriteLine("AH you win");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Paper");

                        if (playerInput == "Rock")
                        {
                            Console.WriteLine("You Loose");
                        }
                        else if (playerInput == "Paper")
                        {
                            Console.WriteLine("You DRAW");
                        }
                        else
                        {
                            Console.WriteLine("You are a Winner");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Scissors");
                        if (playerInput == "Rock")
                        {
                            Console.WriteLine("You Win");
                        }
                        else if (playerInput == "Paper")
                        {
                            Console.WriteLine("You Loose");
                        }
                        else
                        {
                            Console.WriteLine("It is a draw");
                        }
                        break;

                    default:
                        Console.WriteLine("Choose rock,paper,or scissors!");
                        break;

                }
            }
        }
    }
}

       
