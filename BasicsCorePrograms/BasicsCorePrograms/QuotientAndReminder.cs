using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCorePrograms
{
    public class QuotientAndReminder
    {
        public void QuoAndRem()
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Quotient of the number is: " + num / 10);
            Console.WriteLine("The Reminder of the number is: " + num % 10);
        }
    }
}
