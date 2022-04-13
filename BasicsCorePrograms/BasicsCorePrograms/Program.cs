using BasicsCorePrograms;
Console.WriteLine("Welcome to Basic Programs");
bool end = true;
Console.WriteLine("1.Flip Coin");
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
            end = false;
            break;
        default: break;
    }
}