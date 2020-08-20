using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    class Employee
    {
        public string firstName;
        public string lastName;
        public int yearsOfExp;

        public void PrintInfo()
        {
            Console.WriteLine($"My name is {firstName} {lastName} and I have worked for {yearsOfExp} years.");
            Console.ReadKey();
        }



    }

    
}
