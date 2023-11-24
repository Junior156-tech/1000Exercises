Console.Write("Digit quantity of numbers  = ");
int QuantityNum = int.Parse(Console.ReadLine()!);
int[] arrayOfNums = new int[QuantityNum];
int numAssigned = 0;
int minor = 0;
int major = 0;
int countMajor = 0;
int countMinor = 0;
//int numAssignedPair = 0;
//int numAssignedNotPair = 0;

for (int i = 0; i < QuantityNum; i++)
{
    Console.Write($"Position {i + 1} =>  ");
    numAssigned = int.Parse(Console.ReadLine()!);
    arrayOfNums[i] = numAssigned;
}


//major
for (int i = 0; i < QuantityNum; i++)
{
    for (int j = 0; j < QuantityNum; j++)
    {
        if (arrayOfNums[i] > arrayOfNums[j])
        {
            if (arrayOfNums[i] != major)
            {
                countMajor = 0;
            }
            major = arrayOfNums[i];

            ++countMajor;
            if (countMajor == QuantityNum - 1)
            {
                major = arrayOfNums[i];
                break;
            }
        }
    }

    if (countMajor == QuantityNum - 1)
    {
        break;
    }
}

//minor
for (int i = 0; i < QuantityNum; i++)
{
    for (int j = 0; j < QuantityNum; j++)
    {
        if (arrayOfNums[i] < arrayOfNums[j])
        {
            if (arrayOfNums[i] != minor)
            {
                countMinor = 0;
            }
            minor = arrayOfNums[i];

            ++countMinor;
            if (countMinor == QuantityNum - 1)
            {
                minor = arrayOfNums[i];
                break;
            }
        }
    }

    if (countMinor == QuantityNum - 1)
    {
        break;
    }
}


Console.WriteLine($"Major: {major}");
Console.WriteLine($"Minor: {minor}");
