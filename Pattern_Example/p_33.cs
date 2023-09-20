using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
 /*                               1
                                  1 2
                                  1 2 3
                                  1 2 3 4 
                                  1 2 3 4 5 
                                  1 2 3 4
                                  1 2 3 
                                  1 2
                                  1                                                    */
    internal class p_33
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 5 * 2; i++)
            {
                int totalcol = i > 5 ? 5 * 2 - i : i;

                for (int j = 1; j <= totalcol ; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}








