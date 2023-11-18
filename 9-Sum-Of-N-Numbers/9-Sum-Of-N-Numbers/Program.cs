Console.WriteLine("Enter number");
int repeatQuantityNumbers = int.Parse(Console.ReadLine()!);
int limit = 1;
int changingNumber = 0;
int finalSumNumbers = 0;

while (repeatQuantityNumbers >= limit)
{
    Console.Write("Enter a number: ");
    changingNumber = int.Parse(Console.ReadLine()!);

    if (finalSumNumbers > 0)
        finalSumNumbers = finalSumNumbers + changingNumber;

    if (finalSumNumbers == 0)
        finalSumNumbers = changingNumber;

    ++limit;
}

Console.WriteLine();
Console.WriteLine("Final value " + finalSumNumbers);
Console.WriteLine("arithmetic average " + finalSumNumbers / repeatQuantityNumbers);


