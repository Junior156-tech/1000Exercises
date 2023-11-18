Random random = new Random();

for (int i = 1; i < 30; i++)
{
    var num = random.Next(100);
    if (num <= 30 && num >= 10)
    {
        Console.WriteLine("num " + num);
        break;
    }
}