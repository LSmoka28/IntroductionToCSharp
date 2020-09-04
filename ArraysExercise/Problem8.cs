using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    class Problem8
    {
        public static int[] playerHealth = new int[] { 100, 100, 100, 100, 100 };
        private int damageOutput = 40;
        public int selection;

        int player1 = playerHealth[0];
        int player2 = playerHealth[1];
        int player3 = playerHealth[2];
        int player4 = playerHealth[3];
        int player5 = playerHealth[4];

        public void UserInput()
        {
            Console.WriteLine("Enter a number, 1 - 5");
            
            string userIn = Console.ReadLine();
            Int32.TryParse(userIn, out selection);
            Console.WriteLine($"You entered number: {selection}");

            

        }


        // TODO: Add IF to check for 0 health
        // TODO: Add random attack dmg
        // TODO: Add error check for words and numbers over 5
        public void AttackPlayer()
        {
           if (selection == 5)
           {
                player5 -= damageOutput;
               
                if (player5 <= 0)
                {
                    player5 = 0;
                    Console.WriteLine("Player " + selection + " has 0 health remaining.");

                    return;
                }
                Console.WriteLine($"Player 5 was attacked for {damageOutput} damage");
                Console.WriteLine($"Current health is: {player5}");
            }
           if (selection == 4)
           {
                player4 -= damageOutput;
                Console.WriteLine($"Player 4 was attacked for {damageOutput} damage");
                Console.WriteLine($"Current health is: {player4}");
           }
           if (selection == 3)
           {
                player3 -= damageOutput;
                Console.WriteLine($"Player 3 was attacked for {damageOutput} damage");
                Console.WriteLine($"Current health is: {player3}");
           }
           if (selection == 2)
           {
                player2 -= damageOutput;
                Console.WriteLine($"Player 2 was attacked for {damageOutput} damage");
                Console.WriteLine($"Current health is: {player2}");
           }
           if (selection == 1)
           {
                player1 -= damageOutput;
                Console.WriteLine($"Player 1 was attacked for {damageOutput} damage");
                Console.WriteLine($"Current health is: {player1}");
           }


        }











    }
}
