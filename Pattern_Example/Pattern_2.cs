using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice31
{
    internal class Pattern_2
    {

          /*          A  
           *          A B
           *          A B C
           *          A B C D
           
           */
        static void Main(string[]args)
        {
            for (char i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'A'; j <= i ; j++)
                {
                    Console.Write(j);


                }
                Console.WriteLine();
            }
        }
    }
}
