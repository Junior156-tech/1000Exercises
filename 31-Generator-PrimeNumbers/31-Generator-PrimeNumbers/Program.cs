Console.Write($"How much primer number you want: ");
var quantityPrimeNumbers = int.Parse(Console.ReadLine()!);
int count = 0;
long manipulateJ = 0;

for (int i = 2; i > 0; ++i)
{
    if (manipulateJ == 0)
        manipulateJ = 1000000000000000000;

    for (int j = 1; j < manipulateJ; ++j)
    {
        if (i % j == 0)
            count++;
        if (j > i && count == 2)
        {
            Console.WriteLine(i);
            manipulateJ = 0;
            --quantityPrimeNumbers;
            count = 0;
        }
        if (count > 2)
        {
            count = 0;
            manipulateJ = 0;
        }
    }

    if (quantityPrimeNumbers == 0)
        break;
}

