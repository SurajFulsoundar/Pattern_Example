using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
  /*                    1
                        2 1
                        3 2 1
                        4 3 2 1
                        5 4 3 2 1                                                  */ 
    internal class p_23
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j > 0 ; j--)
                {
                   
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}





