using System.Security;

Console.Write("Insert a number for to do fibonaci:  ");
int num = int.Parse(Console.ReadLine()!);
int currentValue = 1;
int beforeValue = 0;
int total = 0;

for (int i = 1; i <= num; i++)
{
    total = currentValue + beforeValue;
    Console.Write(" " + total + " ");

    beforeValue = currentValue;
    currentValue = total;
}                                                                                                                                                                                               
