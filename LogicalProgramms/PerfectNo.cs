using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramms
{
    public class PerfectNo
    {
        int numCheck = 0;
        public void Perfect()
        {
            Console.WriteLine("Enter the no to check Either its perfect no or not");
            int num =Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % 1 == 0)
                {
                    numCheck += i;

                }
            }
            if (numCheck == num)
            {
                Console.WriteLine(" Entered number is Perfect no");
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
                Console.ReadLine();
            }
        }
    }
}
