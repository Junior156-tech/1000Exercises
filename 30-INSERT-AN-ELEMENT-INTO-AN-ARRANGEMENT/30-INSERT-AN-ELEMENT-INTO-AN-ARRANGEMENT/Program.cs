Console.WriteLine("Insert quantity to the arrangement");
int quantity = int.Parse(Console.ReadLine()!);
int[] ints = new int[quantity];
Console.Clear();

for (int i = 0; i < quantity; i++)
{
    Console.Write($"Position {i + 1}: ");
    int numberAssignedForUser = int.Parse(Console.ReadLine()!);
    ints[i] = numberAssignedForUser;

}

Console.WriteLine();
Console.Write("New number: ");
int newNumber = int.Parse(Console.ReadLine()!);
Console.Write("Position you want to put: ");
int position = int.Parse(Console.ReadLine()!);

for (int i = 0; i < quantity; i++)
{
    if (i == position - 1)
        ints[i] = newNumber;

}

Console.WriteLine();
Console.WriteLine("New Array");

for (int i = 0; i < quantity; i++)
    Console.WriteLine(ints[i]);
