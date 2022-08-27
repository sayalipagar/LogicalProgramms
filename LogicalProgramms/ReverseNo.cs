using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramms
{
    public class ReverseNo
    {
        int revNum = 0;
        public void NumberCheck()
        {
            Console.WriteLine("Enter No");
            int num = Convert.ToInt32(Console.ReadLine());
            while(num > 0)
            {
                int reminder = num % 10;
                revNum = revNum * 10 + reminder;
                num = num / 10;
            }
            Console.WriteLine(revNum);
        }
    }
}
