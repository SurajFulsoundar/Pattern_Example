using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
    internal class p_6
    {/*                *
                     * *
                   * * *
                 * * * *
               * * * * *                                               */
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5;  i++)
            {
                for(int j = 5; j > i; j--)
                {
                    Console.Write("  ");
                }
                for(int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
