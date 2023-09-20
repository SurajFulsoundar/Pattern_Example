using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
    internal class p_11
    {/* 1                       
        1 2
        1 2 3
        1 2 3 4
        1 2 3 4 5
        1 2 3 4
        1 2 3
        1 2
        1
                   */
        static void Main(string[] args)
        {
          

            for (int row = 0; row < 5 * 2; row ++)
            {
                int totalCol = row > 5 ? 5 * 2 - row : row;

                for(int col = 1; col <= totalCol; col++)
                {
                    Console.Write(col +"  ");

                }
                Console.WriteLine();
            }
        }
        
      
                                                                         
        
    }
}
