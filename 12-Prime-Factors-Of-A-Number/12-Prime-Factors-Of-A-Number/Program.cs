Console.WriteLine("Enter your number");
double num = int.Parse(Console.ReadLine()!);
int count = 0;

for (double i = 1; i <= num; i++)
{
    if (num % i == 0)
        Console.WriteLine(" ±" + i);
}

