using System;

namespace DiceRoullete
{
    class Dice
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();
            Console.WriteLine("Welcome to Dice Roullete! Press any key to roll the dice against an enemy");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Your turn to roll the dice:");
                
                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("Rolling...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy rolled a " + enemyRandomNum);
                if(playerRandomNum > enemyRandomNum)
                {
                    Console.WriteLine("Player wins this round!");
                    playerPoints++;
                }
                else if(playerRandomNum < enemyRandomNum)
                {
                    Console.WriteLine("Enemy wins this round!");
                    enemyPoints++;
                }
                else
                {
                    Console.WriteLine("Its a tie!");
                   
                }
                Console.WriteLine("The score is now - Player: " + playerPoints + " Enemy: " + enemyPoints + ".");
                Console.WriteLine();
            }
            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("Congrats you win!");
            }
            else if(enemyPoints > playerPoints)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("Its a draw, thats not fun, time for SUDDEN DEATH");
                for(int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Press any key to roll the dice.");

                    Console.ReadKey();

                    playerRandomNum = random.Next(1, 7);
                    Console.WriteLine("You rolled a " + playerRandomNum);

                    Console.WriteLine("Rolling...");
                    System.Threading.Thread.Sleep(1000);

                    enemyRandomNum = random.Next(1, 7);
                    Console.WriteLine("Enemy rolled a " + enemyRandomNum);
                    if (playerRandomNum > enemyRandomNum)
                    {
                        Console.WriteLine("Player wins this round!");
                        playerPoints++;
                    }
                    else if (playerRandomNum < enemyRandomNum)
                    {
                        Console.WriteLine("Enemy wins this round!");
                        enemyPoints++;
                    }
                    else
                    {
                        Console.WriteLine("Its a tie!");

                    }
                    Console.WriteLine("The score is now - Player: " + playerPoints + "Enemy: " + enemyPoints + ".");
                    Console.WriteLine();
                }
                if (playerPoints > enemyPoints)
                {
                    Console.WriteLine("Congrats you win!");
                }
                else
                {
                    Console.WriteLine("You Lose!");
                }
            }
            Console.ReadKey();
        }
        
    }
}