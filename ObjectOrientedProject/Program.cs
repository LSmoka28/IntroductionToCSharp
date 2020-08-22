using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{

    // TODO: Add list of vaild commands
    // TODO: Zombie dont attack wihen ask help or quit

    class Program
    {
        static void Main(string[] args)
        {
            //introdcution text
            Console.WriteLine("Welcome to the Zombie Arena! \n");

            // controls whether battle should continue
            bool isBattleOver = false;

            Player player = new Player();
            Zombie zombo2 = new YummyZombie();
            Zombie zombo1 = new Zombie();
            

            //battle loop
            while (!isBattleOver)
            {
                // prompt player for input
                Console.WriteLine("What would you like to do?");
                string playerInput = Console.ReadLine();
                Console.WriteLine($"You wrote: {playerInput}");

                // good bye text for player quit
                if (playerInput == "quit")
                {
                    isBattleOver = true;
                }
                else if (playerInput == "help")
                {
                    Console.WriteLine("Type words into the console to command the player. \nAll words are accepted in lowercase format with underscores \" _ \" for spaces. \n " +
                       "Type \"list\" to see a list of valid commands.\n");
                }
                else if (playerInput == "check_health")
                {
                    Console.WriteLine($"Your current health is: { player.playerHP}");

                }
                else if (playerInput == "am_i_alive")
                {
                    if (player.IsDefeated)
                    {
                        Console.WriteLine($"Player is alive with {player.playerHP} total health");
                    }
                    else
                    {
                        Console.WriteLine($"Player is defeated");
                        isBattleOver = true;
                    }
                }
                else if (playerInput == "attack")
                {
                    float dmgDealt = player.Attack();
                    zombo1.TakeDamage(dmgDealt);


                    Console.WriteLine($"You attcked for: {dmgDealt} damage");
                    Console.WriteLine($"The zombie has {zombo1.zombieHP} health left");
                }
                else if (playerInput == "heavy_attack")
                {
                    float dmgDealt = player.Attack();
                    float hvyDmg = dmgDealt * 2;
                    zombo1.TakeDamage(hvyDmg);

                    Console.WriteLine($"You attcked very strongly for: {hvyDmg} damage");
                    Console.WriteLine($"The zombie has {zombo1.zombieHP} health left");
                }
                else if (playerInput == "eat")
                {

                    Console.WriteLine("You decided to eat a glowing zombie...");
                    player.Eat(zombo1);
                    Console.WriteLine($"The zombie now has {zombo1.zombieHP}");
                    

                    Console.WriteLine($"Somehow it gave you health. Your health is now {player.playerHP}");

                }

                float zombieAttack = zombo1.Attack();
                player.TakeDamage(zombieAttack);
                Console.WriteLine($"Zombie has dealt {zombieAttack} damage in return");
                Console.WriteLine($"You have {player.playerHP} health left");



                if (player.IsDefeated || zombo1.IsDefeated)
                {
                    if (player.IsDefeated)
                    {
                        Console.WriteLine("You have been eaten by the zombie. You Lose");
                    }
                    else
                    {
                        Console.WriteLine("You win!");
                    }

                    isBattleOver = true;
                }
            }
            Console.WriteLine("Thank you for playing! Press \"ENTER\" to exit");
            // keep the window open
            Console.ReadKey();

        }
    }
}
