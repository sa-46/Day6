using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program4
    {
        static void Main()
        {
            int[] X = new int[] { 1, 2, 3 };
            Program1.PrintArray(X); //1,2,3

            TimesTen(X);
            Program1.PrintArray(X); //10, 20, 30

            //Console.WriteLine(Program3.Multiply(X[1], X[2])); //600

            DoubleTheSize(ref X); 
            Console.WriteLine(X.Length); //6

            X = DoubleTheSizeWithNoRef(X);
            Console.WriteLine(X.Length); //12

            int[] Y;
            Whatever(out Y);
        }

        static void Whatever(out int[] A)
        {
            A = new int[1];
        }

        static int[] DoubleTheSizeWithNoRef(int[] A)
        {
            int[] B = new int[A.Length * 2];
            for (int i = 0; i < A.Length; i++)
            {
                B[i] = A[i];
            }
            return B;
        }

        static void DoubleTheSize(ref int[] A)
        {
            int[] B = new int[A.Length * 2];
            for (int i = 0; i < A.Length; i++)
            {
                B[i] = A[i];
            }
            A = B;
        }

        static void TimesTen(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = A[i] * 10;
            }
        }
    }
}
