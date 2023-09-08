using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
    internal class p_9
    {
        /*        *
                  *  *
                  *  *  *
                  *  *  *  *
                  *  *  *  *  *
                  *  *  *  *
                  *  *  *
                  *  *
                  *                                                   */
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter Number ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int row = 0; row < n * 2;  row++)
            {
               int totalCol = row > n ? n * 2 - row : row;

                for(int col = 0; col < totalCol; col++)
                {
                    Console.Write("*  ");
                }
                Console.WriteLine();
            }
        }
    }
}










