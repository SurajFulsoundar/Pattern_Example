using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Example
{
    internal class p_7
    {
/*            * * * * *     
                * * * *
                  * * *
                    * *
                      *                                     */
        static void Main(string[] args)
        {
            /* for(int i = 5; i >= 1;  i--)
             {
                 for(int j = i; j >= 1; j--)
                 {
                     Console.Write("* ");
                 }
                 Console.WriteLine();

             }
 */
            /*  Denomination problem -
   There are notes of 1000, 500, 200,100,50,20 and 10.
  You need to distribute given amount in such a way that minimum number of notes are given. 
  e.g.If amount to be given is 540 - then 500-- > 1 note , 20-- > 2 notes
  if amount is 8930-- > 1000-- > 8 notes  500-- > 1 note 200-- > 2 notes  20-- > 1 note 10-- > 1 note*/


            Console.WriteLine("Enter the amount ");
            int amt = Convert.ToInt32(Console.ReadLine());

            int count1 = 0 ;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
            int count7 = 0;
            int Total = 0;
            
            while(0 < amt)
            {
                if(amt >= 1000)
                {
                    amt = amt - 1000;
                    count1++;
                }
                if(amt >= 500 && amt <= 1000)
                {
                    amt = amt - 500;
                    count2++;
                }
                if(amt >= 200 && amt <= 500)
                {
                    amt = amt - 200;
                    count3++;
                }
                if(amt >= 100 && amt <= 200)
                {
                    amt = amt - 100;
                    count4++;
                }
                if( amt >= 50 && amt <= 100)
                {
                    amt = amt - 50;
                    count5++;
                }
                if(amt >= 20 && amt <= 50)
                {
                    amt = amt - 20;
                    count6++;
                }
                if(amt >= 10 && amt <= 20)
                {
                    amt = amt - 10;
                    count7++;
                }
              
            }
            Total = count1 + count2 + count3 + count4 + count5 + count6 + count7;

            Console.WriteLine($" Total Notes use in all amount {Total}");
            
            Console.WriteLine($" 1000 Notes is {count1} \n 500 Notes is {count2} \n 200 Notes is {count3} \n  100 Notes is {count4} \n 50 Notes is {count5} \n 20 Notes is {count6} \n 10 notes is {count7}  ");

        }
    }
}
