using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCorePrograms
{
    public class HarmonicNumber
    {
        public void Harmonic()
        {
            double result = 0;
            Console.WriteLine("Enter the N number : ");
            double num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.Write("1/{0} +", i);
                result += 1 / (double)i;
            }
            Console.WriteLine(result);
        }
    }
}
