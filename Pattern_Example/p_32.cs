using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
    internal class p_32
    {
/*                            1
                              0 1
                              0 1 0
                              1 0 1 0
                              1 0 1 0 1                          */
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5;  i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("1 ");
                        }
                        else
                        {
                            Console.Write("0 ");
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("0 ");
                        }
                        else
                        {
                            Console.Write("1 ");
                        }
                    }
                    Console.WriteLine();

                }
                
            }
        }
    }
}
