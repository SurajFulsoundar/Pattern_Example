using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
    internal class p_27
    {
       /*                       5 4 3 2 1   
                                4 3 2 1
                                3 2 1
                                2 1
                                1
                                                                                     */
        static void Main(string[] args)
        {
            for(int i = 5; i >= 1; i--)
            {
                for(int j = i; j >= 1; j--)
                {
                    Console.Write(j +" ");
                }
                Console.WriteLine();
            }

        }
    }
}
