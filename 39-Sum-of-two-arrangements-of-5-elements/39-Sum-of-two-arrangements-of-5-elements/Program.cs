
Console.Write("Insert quantity to the arrangement 1 (5): ");
int quantityArray1 = int.Parse(Console.ReadLine()!);

Console.Write("Insert quantity to the arrangement 2 (5):  ");
int quantityArray2 = int.Parse(Console.ReadLine()!);
int[] Array1 = new int[quantityArray1];
int[] Array2 = new int[quantityArray2];
int[] SumArray1AndArray2 = new int[quantityArray1];
Console.Clear();


Console.WriteLine("insert element for array 1");
Console.WriteLine();

for (int i = 0; i < Array1.Length; i++)
{
    int element = 0;
    Console.Write($"{i + 1} element: ");
    element = int.Parse(Console.ReadLine()!);
    Array1[i] = element;
}

Console.WriteLine();
Console.WriteLine("insert element for array 2");
Console.WriteLine();

for (int i = 0; i < Array2.Length; i++)
{
    int element = 0;
    Console.Write($"{i + 1} element: ");
    element = int.Parse(Console.ReadLine()!);
    Array2[i] = element;
}


for (int i = 0; i < Array1.Length; i++)
    SumArray1AndArray2[i] = Array1[i] + Array2[i];

Console.WriteLine();
Console.WriteLine("Sum of Arrangment 1 and 2");

for (int i = 0; i < Array1.Length; i++)
{
    Console.Write(SumArray1AndArray2[i] + " ");
}