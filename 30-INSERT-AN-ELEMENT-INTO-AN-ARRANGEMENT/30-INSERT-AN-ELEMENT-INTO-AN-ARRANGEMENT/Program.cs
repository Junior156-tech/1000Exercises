Console.Write("Digit quantity of numbers  = ");
int QuantityNum = int.Parse(Console.ReadLine()!);
int[] arrayOfNums = new int[QuantityNum];
int numAssigned = 0;
int otherNumber = 0;
int position = 0;

for (int i = 0; i < QuantityNum; i++)
{
    Console.Write($"Position {i + 1} =>  ");
    numAssigned = int.Parse(Console.ReadLine()!);
    arrayOfNums[i] = numAssigned;
}

Console.Write("Digit your next number: ");
otherNumber = int.Parse(Console.ReadLine()!);


Console.Write("What is the position: ");
position = int.Parse(Console.ReadLine()!);


while (position > numAssigned)
{
    Console.Write("Please digit other position into to the range: ");
    position = int.Parse(Console.ReadLine()!);

}





