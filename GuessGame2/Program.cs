using System;

// <summary>
// An Unimaginative Guess the number engine
// Deliberatly dumb.
// With some deliberate logic
// </summary>
namespace GuessTheNumber
{
    class Program
    {
        // <summary>
        // Main is your programs entrypoint, for most purposes you should
        // regard it as being the first piece of code in your program that will be executed.
        // (this is almost 99% true, and is good enough for now.)
        // </summary>
      
        public static void Main()
        {
            Random nGenerator = new Random();
            //Some error trapping


            Console.WriteLine("Number of guesses you want to have:" );
            int numberOfTries = int.Parse(Console.ReadLine());

            Console.WriteLine("Number you want to guess up to:");
            int ceiling = int.Parse(Console.ReadLine());

            int myNumber = nGenerator.Next(ceiling);

            if (numberOfTries <= 0)
            {
                Console.WriteLine("GuessTheNumber requires 2 parameters the first is the number of guesses, the second is the max number I pick from.");
                Console.ReadKey();
                Main();
               
            }
            if (ceiling <= 1)
            {
                Console.WriteLine("GuessTheNumber requires 2 parameters the first is the number of guesses, the second is the max number I pick from.");
                Console.ReadKey();
                Main();
              
            }
            
           
            int playerGuessNum = 0;
            Console.WriteLine("I am thinking of a whole number between 0 and " + ceiling);
            Console.WriteLine("Can you try and guess it in less than " + numberOfTries + " tries ?");

            for (int i = numberOfTries; i < ceiling && playerGuessNum != myNumber; i--)
            {

                Console.WriteLine("You have " + i.ToString() + " tries left.");
                Console.WriteLine("Take a guess ?");
                string playerGuess = Console.ReadLine();
                playerGuessNum = int.Parse(playerGuess);

                if (playerGuessNum > myNumber)
                {
                    Console.WriteLine("Too High, Try again.");
                }
                else if (playerGuessNum < myNumber)
                {
                    Console.WriteLine("Too Low, Try again.");
                }
                else if (playerGuessNum == myNumber)
                {
                    Console.WriteLine($"Well Done. You took {(numberOfTries + 1) - i} attempts.");
                    Console.WriteLine("Press any key to play again...");
                    Console.WriteLine("\n");
                    Console.ReadKey();
                    Main();
                }
                if (i <= 0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Uh oh! You ran out of attemps! Too bad you didn't guess it in time, I'm just too smart.");
                    Console.WriteLine("Would you like to try again?");
                    Console.WriteLine("\n");
                    Console.ReadKey();
                    Main();

                    // TODO: Add a way to keep score and play only 3 times per run
                }


                }
            
        }
    }
}
