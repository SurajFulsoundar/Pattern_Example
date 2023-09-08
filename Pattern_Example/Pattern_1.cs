using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice31
{
    internal class Pattern_1
    {

        /*                5
         *                4 5
         *                3 4 5
         *                2 3 4 5
         */
        static void Main(string[] args)
        {
            for (int i = 5; i >= 2; i--)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(j);

                }
                Console.WriteLine();
            }
        }
    }
}








