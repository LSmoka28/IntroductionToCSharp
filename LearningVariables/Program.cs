using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVariables
{
    class Program
    {
        static void Main()
        {
            string greeting = "Hello, user! The game's start condition is: ";
            bool gameStarted = false;
            string displayGameState = greeting + gameStarted;
            Console.WriteLine(displayGameState);

            gameStarted = true;
            displayGameState = greeting + gameStarted;
            Console.WriteLine(displayGameState);
            Console.ReadKey();


            string thirstQuenched = "I have had my coffee today: ";
            bool coffeeDrank = true;
            string showThirstyStatus = thirstQuenched + coffeeDrank;
            Console.WriteLine(showThirstyStatus);
            Console.ReadKey();

          
        }

       
            
    }
}
