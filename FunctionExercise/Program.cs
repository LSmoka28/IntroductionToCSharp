using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExercise
{
    class Program
    {
        public static void Main()
        {
            Game myGame = new Game();

            myGame.score = 100;
            myGame.Start();
            Console.ReadKey();
        }
    }

    public class Game
    {
        public int score = 0;

        public void Start()
        {
            Console.WriteLine("The current score is: " + score);
            PrintScore(25);
            PrintScore(50);
            PrintScore(75);
        }

        public int AddToScore(int add)
        {
            score = score + add;
            return score;
        }

        public string PrintScore(int add)
        {
            Console.WriteLine("You scored! The score is now: " + AddToScore(add));
            return null;
        }



    }

}
