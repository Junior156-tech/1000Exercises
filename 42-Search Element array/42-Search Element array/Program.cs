

Console.Write("Insert quantity to the array: ");
int quantity = int.Parse(Console.ReadLine()!);
int[] array = new int[quantity];
int count = 0;
int numSearch = 0;
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    int num = 0;
    Console.Write($"Insert {i + 1} number: ");
    num = int.Parse(Console.ReadLine()!);
    array[i] = num;
}

Console.WriteLine("Insert your number for to search");
numSearch = int.Parse(Console.ReadLine()!);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == numSearch)
        ++count;
}

if(count == 0)
    Console.WriteLine("Your number don't exist");
else
    Console.WriteLine($"Your number {numSearch} exist {count} times");