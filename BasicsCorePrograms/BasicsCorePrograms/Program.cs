using BasicsCorePrograms;
Console.WriteLine("Welcome to Basic Programs");
bool end = true;
Console.WriteLine("1.Flip Coin\n2.Leap Year\n3.Power Of two\n4.Harmonic number\n5.Prime Factors\n6.Quotient and reminder\n7.Swap Two numbers\n8.Even or Odd\n9.Vowel or Consonent\n10.Largest NUmber");
while (end)
{
    Console.WriteLine("Take an Option to execute");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            FlipCoin flipCoin = new FlipCoin();
            flipCoin.Flip();
            break;
        case 2:
            LeapYear year = new LeapYear();
            year.Year();
            break;
        case 3:
            PowerOfTwo power = new PowerOfTwo();
            power.Power();
            break;
        case 4:
            HarmonicNumber number = new HarmonicNumber();
            number.Harmonic();
            break;
        case 5:
            Factors n = new Factors();
            n.PrimeFactor();
            break;
        case 6:
            QuotientAndReminder num1 = new QuotientAndReminder();
            num1.QuoAndRem();
            break;
        case 7:
            SwapTwoNumbers num2 = new SwapTwoNumbers();
            num2.Swap();
            break;
        case 8:
            EvenOrOdd num3 = new EvenOrOdd();
            num3.Number();
            break;
        case 9:
            VowelOrConsonent num4 = new VowelOrConsonent();
            num4.Alphabets();
            break;
        case 10:
            LargestNumber num5 = new LargestNumber();
            num5.Largest();
            break;
        case 11:
            Console.WriteLine("Enter a valid choice");
            end = false;
            break;
        default: break;
    }
}