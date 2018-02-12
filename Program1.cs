using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program1
    {
        static void Main()
        {
            int[] A = new int[] { 1, 2, 3 };

            int[] B = SquareArray(A);
            PrintArray(B); //1,4,9

            int[] C = IncrementArray(A);
            PrintArray(C); //2,3,4

            int[] D = ApplyOperation(A, Square);
            PrintArray(D); //1,4,9
            int[] E = ApplyOperation(A, TimesTen);
            PrintArray(E); //10,20,30

            MickeyMouse times100 = delegate (int x) { return x * 100; };
            int[] F = ApplyOperation(A, times100); //100,200,300

            MickeyMouse times100b = delegate (int x) { return TimesN(x, 100); };
            int[] G = ApplyOperation(A, times100b); //100,200,300

            int[] H = ApplyOperation(A, delegate (int x) { return x * 100; });

            int[] I = ApplyOperation(A, (int x) => { return x * 100; });
        }

        static int Square(int x) { return x * x; }
        static int Increment(int x) { return x + 1; }
        static int TimesTen(int x) { return x * 10; }
        static int TimesN(int x, int n ) { return x * n; }
        static double Sqrt(double x) { return Math.Sqrt(x); } // not a MickeyMouse
        static int Sqrt(int x) { return (int) Math.Round(Math.Sqrt(x)); }

        delegate int MickeyMouse(int b);
        delegate int MinnieMouse(int b, int d);

        static int[] ApplyOperation(int[] A, MickeyMouse ops)
        {
            int[] newArray = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                newArray[i] = ops(A[i]); //applying ops to each element
            }
            return newArray;
        }


        //this method will perform square operation for each element of the array
        static int[] SquareArray(int[] A) {
            int[] newArray = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                newArray[i] = A[i] * A[i];
            }
            return newArray;
        }

        //this method will increment each element of the array by 1
        static int[] IncrementArray(int[] A)
        {
            int[] newArray = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                newArray[i] = A[i] + 1;
            }
            return newArray;
        }

        public static void PrintArray(int[] A)
        {
            Console.Write("[ ");
            Console.Write(string.Join(",", A));
            Console.WriteLine(" ]");
        }


    }
}
