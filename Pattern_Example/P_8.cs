using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
    internal class P_8
    {
/*                    1
                      1  2
                      1  2  3
                      1  2  3  4
                      1  2  3  4  5                                     */
        static void Main(string[] args)
        {
            for(int row = 1; row <= 5;  row++)
            {
                for(int col = 1; col <= row; col++)
                {
                    Console.Write($" {col}");
                }
                Console.WriteLine();
            }

        }
    }
}
