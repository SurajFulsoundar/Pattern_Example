using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice31
{
    internal class Pattern_6
    {
        /*      *
         *      *
         *  * * * * *
         *      *
         *      *


         */
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)    // row
            {
                for (int j = 1; j <= 5; j++)   // colaum
                {
                    if (i == 3 || j == 3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" ");


                }

                Console.WriteLine();
            }

        }
    }
}
