using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int count = 10; count < 20; count ++)
            {
                Console.WriteLine("The value of count is now " + count + ".");
                if (count == 16)
                {
                    break;
                }

            }
            Console.WriteLine("The loop is now finished.");
            Console.ReadKey();





        }
    }
}
