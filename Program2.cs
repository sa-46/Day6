using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program2
    {
        static void Main()
        {
            InitializeArray();
            int userInput = GetInput();
            Criteria c = delegate (int x) { return x == userInput; };
            int count = CountByCriteria(c);
            PrintOutput(count, userInput);

            int evenNumbers = CountByCriteria((int x) => { return x % 2 == 0; });
            Console.WriteLine("Even elements: {0}", evenNumbers);
        }

        delegate bool Criteria(int x); //new

        static int CountByCriteria(Criteria ops)
        {
            int count = 0;

            for (int i = 0; i <= theArray.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= theArray.GetLength(1) - 1; j++)
                {
                    if (ops(theArray[i, j])) //use the method passed to check
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static int[,] theArray;


        static void InitializeArray()
        {
            theArray = new int[,]
            {
                {5,3 }, {2,9 }, {2,9 },
                {5,1 }, {7,1 }, {8,3 },
                {0,3 }, {2,2 }, {9,7 }
            };
        }

        static int GetInput()
        {
            Console.Write("Please enter a number (0-9): ");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

        static int CountInteger(int integerToFind)
        {
            int count = 0;

            for (int i = 0; i <= theArray.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= theArray.GetLength(1) - 1; j++)
                {
                    if (theArray[i, j] == integerToFind)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static void PrintOutput(int count, int integerToFind)
        {
            if (count == 0)
            {
                Console.WriteLine("There is no {0} in the array.", integerToFind);
            }
            else
            {
                Console.WriteLine("The number of {0} is {1}.", integerToFind, count);
            }
        }
    }
}
