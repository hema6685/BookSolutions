using System;

namespace ConsoleApp_betting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guy player = new Guy() { Cash=100,Name= "The player" };

            Console.WriteLine("Welcome! The odds are " + odds);
            //9.The program keeps running while the player has cash.
            while (player.Cash>0) {
                //1. Have the Guy object print the amount of cash it has.
                player.WriteMyInfo();

                //2.Ask the user how much money to bet.
                Console.WriteLine("how much money to bet? ");
                
                //3.Read the line into a string variable called howMuch.
                string howMuch = Console.ReadLine();
                
                //4.Try to parse it into an int variable called amount.
                if (int.TryParse(howMuch, out int amount))
                {
                    //5.If it parses, the player gives the amount to an int variable called pot. It gets multiplied by two, because it’s a
                    //double-or - nothing bet.
                    int pot = amount;
                    pot *= 2;

                    //6.The program picks a random number between 0 and 1.                   
                    //7.If the number is greater than odds, the player receives the pot.
                    if (random.NextDouble() > odds)
                    {
                        player.ReceiveCash(pot);
                        Console.WriteLine("You win " + pot);
                    }
                    else
                    {//8.If not, the player loses the amount they bet.
                        player.GiveCash(pot);
                        Console.WriteLine("Bad luck, you lose.");
                    }
                }
                
            }
            Console.WriteLine("The house always wins.");
        }
    }
}
