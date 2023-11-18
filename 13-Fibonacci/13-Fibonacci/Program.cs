
Console.WriteLine("Enter the number");
int num = int.Parse(Console.ReadLine()!);
int currentNum = 0;
int beforeNum = 0;
int beforebeforeNum = 0;
int lastNum = 0;
int count = 0;


for (int i = 0; i < num; i++)
{
    currentNum = beforeNum + lastNum;

    if (currentNum >= 2)
    {
        beforeNum = lastNum;
        lastNum = currentNum;
    }

    Console.Write(" " + currentNum + " ");

    if (count == 2)
        beforeNum = lastNum;
    if (lastNum == 0)
        lastNum++;

    ++count;


}