using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
    internal class p_22
    { /*                5
                        5 4
                        5 4 3
                        5 4 3 2
                        5 4 3 2 1                     */
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= i; j--)             
                {                                       
                    Console.Write(j +" ");               


                }
                Console.WriteLine();

            }
        }
    }
}
