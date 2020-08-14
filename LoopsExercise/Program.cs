using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogs = 0;
            int score = 0;

            while (numberOfDogs < 10)
            {
               // adds one dog every loop
                numberOfDogs++;
                Console.WriteLine("The number of dogs in the room is now " + numberOfDogs + ".");

                // add 20 to score after dogs reach 10
                // break out after 100 score is reached
                while (numberOfDogs == 10 && score < 100)
                {
                    score += 20;
                    Console.WriteLine("The score is: " + score);

                    if (score > 100)
                    {
                        break;
                    }
                }
            }

            // adds one bag of dog food every loop
            for (int bagsOfDogFood = 1; bagsOfDogFood <= 20 ; bagsOfDogFood++)
            {
                Console.WriteLine("You have " + bagsOfDogFood + " bags of dog food.");
            }
            Console.ReadKey();
        }
    }
}
