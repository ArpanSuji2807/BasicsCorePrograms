using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCorePrograms
{
    public class VowelOrConsonent
    {
        public void Alphabets()
        {
            char vowel;
            Console.WriteLine("Enter an alphabet : ");
            vowel = Console.ReadKey().KeyChar;
            vowel=char.ToLower(vowel);
            if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
            {
                Console.WriteLine(" :- It is a vowel");
            }
            else
            {
                Console.WriteLine(" :- It is a consonent");
            }
        }
    }
}
