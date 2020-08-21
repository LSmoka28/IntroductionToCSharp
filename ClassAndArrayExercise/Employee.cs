using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndArrayExercise
{
    class Employee
    {
        /// <summary>
        /// stores the information of any new instance Employee class
        /// </summary>
        public string firstName;
        public string lastName;
        public int yearsExp;

        // print information method for a desired employee
        public void PrintInfo()
        {
            Console.WriteLine($"{firstName} {lastName} has worked for {yearsExp} years.");
            Console.ReadKey();
        }

        


    }
}
