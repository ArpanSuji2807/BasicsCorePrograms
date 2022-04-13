using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCorePrograms
{
    public class SwapTwoNumbers
    {
        public void Swap()
        {
            Console.WriteLine("Enter the 1st Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("swapped into: " + num1);
            Console.WriteLine("swapped into: " + num2);

        }
    }
}
