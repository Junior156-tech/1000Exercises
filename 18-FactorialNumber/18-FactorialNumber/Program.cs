Console.WriteLine("Enter your number");
int num = int.Parse(Console.ReadLine()!);


for (int i = num -1; i <= num; i--)
{
    if(i == 0) 
        break; 

    num = num * i;
}

Console.WriteLine("The factorial es: " + num);