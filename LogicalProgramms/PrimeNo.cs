using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramms
{
    public class PrimeNo
    { 
        int count = 0;
        public void PrimeCheck()
        {
            Console.WriteLine("Enter no to check whether its prime no or not");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num  % 1 == 0)
                { 
                count++;
                }
            }
        if (count == 2)
            
            {
                Console.WriteLine(" Entered number is Prime No");

            }
            else
            {
                Console.WriteLine(" Entered number is not a Prime number");
                Console.ReadLine();
            }

        }
    }
}
