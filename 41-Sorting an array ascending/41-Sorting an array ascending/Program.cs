

Console.Write("Insert quantity to the array: ");
int quantity = int.Parse(Console.ReadLine()!);
int[] array = new int[quantity];
int aux = 0;

Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    int num = 0;
    Console.Write($"Insert {i + 1} number: ");
    num = int.Parse(Console.ReadLine()!);
    array[i] = num;
}

for (int i = 0; i < array.Length; i++)
{
    for (int j = i; j < array.Length; j++)
    {
        if (array[j] < array[i])
        {
            aux = array[j];
            array[j] = array[i];
            array[i] = aux;
        }
    }
}


Console.WriteLine();
Console.WriteLine("Descending sort");

for (int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i]);

