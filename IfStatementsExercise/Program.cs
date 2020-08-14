using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementsExercise
{
    class Program
    {
        static void Main()
        {
            bool playerAlive = true;
            

            if (playerAlive)
            {
                Console.WriteLine("You are still alive... for now");
            }
            else
            {
                Console.WriteLine("Told you so... You are now dead. Ha!");
            }

            int invulnerabilityTimer = 15;
            

            if (invulnerabilityTimer > 0)
            {

                Console.WriteLine("You are invincible!");
                if (playerAlive)
                {
                    invulnerabilityTimer --;
                    Console.WriteLine("Time left: " + invulnerabilityTimer);
                }
            }
            else if (invulnerabilityTimer <= 0)
            {
                Console.WriteLine("You are now vunerable to damage");
            }
            else if (invulnerabilityTimer < 0)
            {
                invulnerabilityTimer = 0;

            }

            Console.ReadKey();

            













        }
        
    }
}
