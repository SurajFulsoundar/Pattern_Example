using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
    internal class p_16
    {
/*               A A A A A
                 B B B B B
                 C C C C C
                 D D D D D
                 E E E E E                                                       */
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write((char) (i + 'A'));


                }
                Console.WriteLine();


            }
        }
    }
}
