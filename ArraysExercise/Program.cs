using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    class Program
    {

        static int[] data = new int[11];
        static int[] reverseArray = new int[4];
        static int[] customArr = new int[5];
        static int[,] gridArr =
           {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
        static int[,] days = new int[29, 5];
        
        

        #region Sum Of Rows Method
        //method for finding the sum of rows
        static void RowSum(int[,] arr)
        {
            int i, j, sum1 = 0;
                        
            Console.WriteLine("Finding the sum of each row");

            for (i = 0; i < 29; ++i)
            {
                for (j = 0; j < 5; ++j)
                {
                    sum1 = sum1 + arr[i, j];
                }
                Console.WriteLine("The sum of row " + i + " is " + sum1);
                sum1 = 0;
            }
        }
        #endregion

        #region Sum of Column Method
        // Method for finding the sum of column
        static void ColomnSum(int[,] arr)
        {
            int i, j, sum2 = 0;

            Console.WriteLine("Finding the sum of each column");

            for (i = 0; i < 5; ++i)
            {
                for (j = 0; j < 29; ++j)
                {
                    sum2 = sum2 + arr[j, i];
                }
                Console.WriteLine("The sum of coloumn " + i + " is " + sum2);
                sum2 = 0;
            }
        }
        #endregion


        static void Main(string[] args)
        {
            #region Problem 3
            //// problem 3
            //for (int i = 0; i < data.Length; i++)
            //{
            //    data[i] = i;
            //}
            //foreach (int number in data)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Problem 4
            //problem 4

            //Console.WriteLine("Enter 4 numbers and print in reverse");
            //int[] arrRev = reverseArray;
            //for (int i = 0; i < reverseArray.Length; i++)
            //{
            //    Console.WriteLine("Enter a number");
            //    string input = Console.ReadLine();
            //    Int32.TryParse(input, out reverseArray[i]);
            //}

            //Array.Reverse(arrRev);
            //foreach (int reverNum in arrRev)
            //{
            //    Console.WriteLine(reverNum + " ");
            //}
            #endregion

            #region Problem 5
            //problem 5


            //Console.WriteLine("Input 5 numbers");
            //for (int v = 0; v < customArr.Length; v++)
            //{
            //    Console.WriteLine("Enter a number: ");
            //    string userInput = Console.ReadLine();
            //    Int32.TryParse(userInput, out customArr[v]);

            //    if (!Int32.TryParse(userInput, out customArr[v]))
            //    {
            //        Console.WriteLine("Something went wrong.. Please enter a number");
            //        Console.ReadLine();
            //    }
            //}
            //int maxValue = customArr.Max();
            //int minValue = customArr.Min();

            //Console.WriteLine($"The minimum value you entered is {minValue} and the maximum value you entered is {maxValue}");
            //foreach (int input in customArr)
            //{
            //    Console.WriteLine(input);
            //}
            #endregion

            #region Problem 6 
            //problem 6


            //int val1 = gridArr.GetLength(0);
            //int val2 = gridArr.GetLength(1);
            //Console.WriteLine("Print a 3x3 array grid with numb 1-9");

            //for(int i = 0; i < val1; i++)
            //{
            //    for(int j = 0; j < val2; j++)
            //    {
            //        Console.Write("{0}", gridArr[i,j]);
            //    }
            //    Console.Write("\n");
            //}
            #endregion

            #region Problem 7
            Random random = new Random();
            

            for (int i = 0; i < 29; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    days[i, j] = random.Next(1, 30);
                    Console.Write("{0} ", days[i, j]);
                }
                    Console.WriteLine("");              
            }

            

            RowSum(days);
            ColomnSum(days);

            #endregion

            Console.ReadKey();
        }



    }
}
