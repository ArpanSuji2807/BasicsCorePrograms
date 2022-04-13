using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCorePrograms
{
    public class Factors
    {
        int count = 0;

        public void PrimeFactor()
        {
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number; i++)
                if (number % i == 0)
                {
                    count = 0;
                    while (number % i == 0)
                    {
                        number = number / i;
                        count++;
                    }
                    Console.WriteLine("The prime factors of the number is : " + i);
                }
        }
    }
}
