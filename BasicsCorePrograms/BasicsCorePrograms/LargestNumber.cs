using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCorePrograms
{
    public class LargestNumber
    {
        public void Largest()
        {
            Console.WriteLine("Enter the 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The greater number is: " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The graeter number is : " + num2);
            }
            else
            {
                Console.WriteLine("The greater number is: " + num3);
            }
        }
    }
}
