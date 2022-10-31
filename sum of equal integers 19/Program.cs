using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sum_of_equal_integers_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sum(3, 3));
            Console.WriteLine(sum(3, 5));
            Console.WriteLine(sum(3, -9));
            Console.ReadLine();


        }
        public static int sum(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }



    }
}
