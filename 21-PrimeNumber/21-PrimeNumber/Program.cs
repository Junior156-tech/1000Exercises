Console.WriteLine("Enter your number");
double num = int.Parse(Console.ReadLine()!);
int count = 0;

for (double i = 1; i <= num; i++)
{
    if (num % i == 0)
        ++count;
}

if(count == 2)
    Console.WriteLine(num + "  is prime");
else
    Console.WriteLine(num + " it's not prime");
