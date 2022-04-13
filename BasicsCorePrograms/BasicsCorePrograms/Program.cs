using BasicsCorePrograms;
Console.WriteLine("Welcome to Basic Programs");
bool end = true;
Console.WriteLine("1.Flip Coin\n2.Leap Year");
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
            end = false;
            break;
        default: break;
    }
}