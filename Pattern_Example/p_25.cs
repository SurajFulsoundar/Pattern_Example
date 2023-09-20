using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
    internal class p_25
    {
        /*                     1 2 3 4 5
                               2 3 4 5
                               3 4 5
                               4 5   
                               5                                                          */
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5;  i++)
            {
                for(int j = i; j <= 5; j++)
                {
                    Console.Write(j +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
