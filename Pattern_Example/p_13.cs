using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
    internal class p_13
    {
/*                      1 2 3 4 5 
                        1 2 3 4 5
                        1 2 3 4 5
                        1 2 3 4 5
                        1 2 3 4 5                             */
        static void Main(string[] args)
        {
            for(int i = 1;  i <= 5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    Console.Write(j+"  ");
                }
                Console.WriteLine();

            }

        }
    }
}
