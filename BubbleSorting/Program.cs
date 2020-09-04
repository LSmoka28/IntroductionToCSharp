using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    class Program
    {

        static int swaps;
        static int comparisons; 

        static void PrintArray(int[] array)
        {
            for (int i = 0; i< array.Length; i++)
            {
                Console.Write("{0}, \t", array[i]);
                if (i % 10 == 9)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            //foreach (int number in array)
            //{
            //    Console.Write("{0} ", number);
            //}
        }
        static void BubbleSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return;
            }

            
            bool swapped = true;

            while(swapped)
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                        swaps++;
                        swapped = true;
                    }
                    comparisons++;
                }
            }
        }

        static void OptimisedBubbleSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return;
            }

            int comp = 0;
            bool swapped = true;

            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < array.Length-comp - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                        swaps++;
                        swapped = true;    
                    }
                   
                }
                for (int i = array.Length-1; i > 0 + comp; i--)
                {
                    if( array[i] < array[i - 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = tmp;
                    }
                }
                comp = comparisons;
                comparisons++;
                
                
            }

        }



        static void Main(string[] args)
        {
            //define the array
            int[] arrayToBeSorted = new int[]
            {
                14,65,63,1,54,
                89,84,9,98,57,
                71,18,21,84,69,
                28,11,83,13,42,
                64,58,78,82,13,
                9,96,14,39,89,
                40,32,51,85,48,
                40,23,15,94,93,
                35,81,1,9,43,
                39,15,17,97,52
            };

            //print the array
            Console.WriteLine("Unsorted");
            PrintArray(arrayToBeSorted);

            Console.WriteLine("\nSorted");
            BubbleSort(arrayToBeSorted);
            PrintArray(arrayToBeSorted);
            Console.WriteLine("The amount of comparisons: " + comparisons);
            Console.WriteLine("The amount of swaps: " + swaps);

            

            OptimisedBubbleSort(arrayToBeSorted);
            Console.WriteLine("The amount of comparisons: " + comparisons);
            Console.WriteLine("The amount of swaps: " + swaps);


            Console.ReadLine();

        }
    }
}
