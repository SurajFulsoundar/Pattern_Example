using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
    internal class p_29
    {
/*              1
                2  3 
                4  5  6
                7  8  9  10
                11  12  13  14  15                                         */
        static void Main(string[] args)
        {
            int n = 1;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(n +" ");
                    n++;
                }
                Console.WriteLine();
            }

        }
    }
}
