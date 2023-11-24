Console.Write("Digit quantity of numbers  = ");
int QuantityNum = int.Parse(Console.ReadLine()!);
int[] sumNums = new int[QuantityNum];
int numAssigned = 0;
int numAssignedPair = 0;
int numAssignedNotPair = 0;

for (int i = 0; i < QuantityNum; i++)
{
    Console.Write($"Position {i + 1} =>  ");
    var a = i;
    numAssigned = int.Parse(Console.ReadLine()!);
    sumNums[i] = numAssigned;
}

for (int i = 0; i < sumNums.Length; i++)
{
    if (sumNums[i] % 2 == 0)
        numAssignedPair = numAssignedPair + sumNums[i];
    else
        numAssignedNotPair = numAssignedNotPair + sumNums[i];
}

Console.WriteLine($"Sum of pairs: {numAssignedPair}");
Console.WriteLine();
Console.WriteLine($"Sum of not pairs: {numAssignedNotPair}");