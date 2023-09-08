using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
    internal class p
    {
/*        * * * * *
          * * * *
          * * *
          * *
          *                                    */
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            { 
                for(int j = 5; j > i; j --)
                {
                   // if(j+i <= 4)
                   // {
                        Console.Write(" * ");
                    //}
                    //else
                   // {
                    //    Console.Write(" ");
                    //}

                }
                Console.WriteLine("\n");
            }

        }
    }
}
