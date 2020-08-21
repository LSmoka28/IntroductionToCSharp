using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndArrayExercise
{
    class Program
    {
        static void Main()
        {


            /// creates new instance of an employee
            /// to assign value too
            Employee jackie = new Employee
            {
                firstName = "Jackie",
                lastName = "Chan",
                yearsExp = 35
            };
            jackie.PrintInfo();

            Employee bruce = new Employee
            {
                firstName = "Bruce",
                lastName = "Willis",
                yearsExp = 25
            };
            bruce.PrintInfo();

            Employee morgan = new Employee
            {
                firstName = "Morgan",
                lastName = "Freeman",
                yearsExp = 30
            };
            morgan.PrintInfo();




            ///assigns years of experience of employee
            ///to an index in the teamList array in the Team class
            Team.teamList[0] = jackie.yearsExp;
            Team.teamList[1] = bruce.yearsExp;
            Team.teamList[2] = morgan.yearsExp;

            ///call a method from the Team class to calculate the sum and average
            ///of years the employees worked
            Team.AvgYearsExp();

            
        }
    }
}
