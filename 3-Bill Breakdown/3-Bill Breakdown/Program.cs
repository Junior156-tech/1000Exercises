

Console.WriteLine("Enter your amount");
var num =  int.Parse(Console.ReadLine());

int C100 = 100;
int C50 = 50;
int C20 = 20;
int C10 = 10;
int C5 = 5;
int C1 = 1;

int remaining = 0;
int quantityBills100 = 0;
int quantityBills50 = 0;
int quantityBills20 = 0;
int quantityBills10 = 0;
int quantityBills5 = 0;
int quantityBills1 = 0;


//1650

if(num < 100)
{
    if(num < 0)
    {
        Console.WriteLine("Debe colocar un valor mayor o igual a 0");
        return;
    }

    remaining = num;
}
if (num >= C100)
{
     quantityBills100 = num / C100;
     remaining = num - (quantityBills100 * C100);
}
if (remaining >= C50)
{
    quantityBills50 = remaining / C50;
    remaining = remaining - (quantityBills50 * C50) ;
}
if (remaining >= C20)
{
    quantityBills20 = remaining / C20;
    remaining = remaining - (quantityBills20 * C20);
}
if (remaining >= C10)
{
    quantityBills10 = remaining / C10;
    remaining = remaining - (quantityBills10 * C10);
}
if (remaining >= C5)
{
    quantityBills5 = remaining / C5;
    remaining = remaining - (quantityBills5 * C5);
}
if (remaining >= C1)
{
    quantityBills1 = remaining / C1;
    remaining = remaining - (quantityBills5 * C1);
}


Console.WriteLine($"Billetes de 100: {quantityBills100}");
Console.WriteLine($"Billetes de 50: {quantityBills50}");
Console.WriteLine($"Billetes de 20: {quantityBills20}");
Console.WriteLine($"Billetes de 10: {quantityBills10}");
Console.WriteLine($"Billetes de 5: {quantityBills5}");
Console.WriteLine($"Billetes de 1: {quantityBills1}");
