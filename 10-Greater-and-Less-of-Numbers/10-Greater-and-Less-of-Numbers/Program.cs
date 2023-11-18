Console.WriteLine("Enter number");
int repeatQuantityNumbers = int.Parse(Console.ReadLine()!);
int limit = 1;
int changingNumber = 0;
int finalSumNumbers = 0;
int numGreater = 0;
int numLess = 0;

while (repeatQuantityNumbers >= limit)
{
    Console.Write("Enter a number: ");
    changingNumber = int.Parse(Console.ReadLine()!);
    
    if(numGreater < changingNumber)
        numGreater = changingNumber;
    if (numLess > changingNumber || numLess == 0)
        numLess = changingNumber;

    if (finalSumNumbers > 0)
        finalSumNumbers = finalSumNumbers + changingNumber;

    if (finalSumNumbers == 0)
        finalSumNumbers = changingNumber;

    ++limit;
}

Console.WriteLine();
Console.WriteLine("Final value: " + finalSumNumbers);
Console.WriteLine("arithmetic average: " + finalSumNumbers / repeatQuantityNumbers);
Console.WriteLine();
Console.WriteLine("Less num: " + numLess);
Console.WriteLine("Greater num: " + numGreater);
Console.WriteLine($"Distance of greater and less: { numGreater-numLess}");