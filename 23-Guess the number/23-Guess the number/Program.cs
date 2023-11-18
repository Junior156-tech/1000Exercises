Random random = new Random();
var num = random.Next(100);
var numUser = 0;

for (int i = 1; i > 0 ; i++)
{
    Console.WriteLine("Guess the number");
    numUser = int.Parse(Console.ReadLine()!);

    if(numUser == num)
    {
        Console.WriteLine("You win");
        break;
    }
    if(numUser > num)
    {
        Console.WriteLine("Muy alto");
    }
    if(numUser < num)
    {
        Console.WriteLine("Muy bajo");
    }
   
}