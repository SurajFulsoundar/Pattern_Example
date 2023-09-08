using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice31
    {
        internal class Pattern_7
        {

              /*          1 2 3 4 5
               *          1 2 3 4
               *          1 2 3 
               *          1 2
               *          1 
               */
            
        static void Main(string[] args)
            {
                for (int i = 5; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);

                    }
                    Console.WriteLine();

                }
            }
        }
    }


    

