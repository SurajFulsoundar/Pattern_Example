using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
    internal class p_18
    {
        /*                      5 4 3 2 1
                                5 4 3 2 1
                                5 4 3 2 1         
                                5 4 3 2 1 
                                5 4 3 2 1  
                                                                                   */
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for (int j = 5; j > 0; j--)
                {
                    Console.Write(j +" ");

                }
                Console.WriteLine();

            }

        }


    }
}
