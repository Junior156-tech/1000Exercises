
Console.Write("Insert quantity to the arrangement: ");
int quantity = int.Parse(Console.ReadLine()!);
int[] ListOfNumbers = new int[quantity];
int[] ListOfNumbersNew = new int[quantity - 1];
Console.Clear();

for (int i = 0; i < quantity; i++)
{
    Console.Write($"Position {i + 1}: ");
    int numberAssignedForUser = int.Parse(Console.ReadLine()!);
    ListOfNumbers[i] = numberAssignedForUser;

}


Console.Write("Position you want to put: ");
int position = int.Parse(Console.ReadLine()!);
int count = 0;

for (int i = 0; i < quantity; i++)
{
    if (i == quantity - 1)
    {
        i = quantity + 1;
        continue;
    }
    if (position == i + 1)
        count++;
    if (count == 0)
        ListOfNumbersNew[i] = ListOfNumbers[i];
    if (count > 0)
        ListOfNumbersNew[i] = ListOfNumbers[i + 1];

}

Console.WriteLine();
Console.WriteLine("New Array");

for (int i = 1; i < quantity; i++)
{
    Console.WriteLine($"Position {i}  => " + ListOfNumbersNew[i - 1]);
}

