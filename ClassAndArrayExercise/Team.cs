using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndArrayExercise
{
    class Team
    {
        //initialize the array for teamList
        public static int[] teamList = new int[3];

        ///aquire the sum of the integers in the array
        ///and get the average
        public static void AvgYearsExp()
        {

            int sumOfYears = 0;
            foreach (int empYears in teamList)
            {
                sumOfYears += empYears;
            }
            Console.WriteLine($"The average years worked between employees is {sumOfYears / teamList.Length}");
            Console.ReadKey();

            ///code below is a test to print the values of the indexs
            //Console.WriteLine($"{teamList[0]} {teamList[1]} {teamList[2]}");
            //Console.ReadKey();
        }


    }
}
