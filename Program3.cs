using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program3
    {
        static void Main()
        {
            int x = 3;
            int y = 4;

            Console.WriteLine(Multiply(x, y)); //12

            Swap(ref x, ref y);
            Console.WriteLine("{0}, {1}", x, y); // 4, 3

        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int Multiply(int a, int b)
        { // int a = x; int b = y;
            return a * b;
        }



    }
}
