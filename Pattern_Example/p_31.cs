﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
    internal class p_31
    {
/*      code : 1          1                         code : 2           1 
                          1 0                                          0 1
                          1 0 1                                        1 0 1
                          1 0 1 0                                      0 1 0 1
                          1 0 1 0 1                                    1 0 1 0 1                                                                                */
        static void Main(string[] args)
        {
 // Code : 1 is without comments and code : 2  is all code.
 
            for(int i = 1; i <= 5; i++)
            {
               /* if (i % 2 == 0)                                      //    ------------------->      code : 2 
                {*/
                    for (int j = 1; j <= i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("1 ");
                        }
                        else
                        {
                            Console.Write("0 ");
                        }
                    }
                   Console.WriteLine();

               /* }
                 else
                 {
                     for (int j = 1; j <= i; j++)
                     {
                         if (j % 2 == 0)
                         {
                             Console.Write("0 ");
                         }
                         else
                         {
                             Console.Write("1 ");
                         }
                     }
                    Console.WriteLine();
                }
*/
            }

        }

    }
}










