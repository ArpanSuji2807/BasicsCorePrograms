using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCorePrograms
{
    public class FlipCoin
    {
        const double HEAD = 0.5;
        int count_head = 0, count_tail = 0;
        public void Flip()
        {
            Console.WriteLine("Enter the number of times to flip the coin : ");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= value; i++)
            {
                Random random = new Random();
                double a = random.NextDouble();
                if (a < HEAD)
                {
                    count_tail++;
                }
                else
                {
                    count_head++;
                }
            }
            Console.WriteLine("Head percentage: " + (double)(count_head * 100) / value);
            Console.WriteLine("Tail percentage: " + (double)(count_tail * 100) / value);
        }
    }
}
