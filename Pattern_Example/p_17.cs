﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
    internal class p_17
    {
        /*               A B C D E 
                         A B C D E 
                         A B C D E 
                         A B C D E 
                         A B C D E  
                                                                            */
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5;  i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write((char)(j + 'A'));
                }
                Console.WriteLine();
            }
        }
    }
}
