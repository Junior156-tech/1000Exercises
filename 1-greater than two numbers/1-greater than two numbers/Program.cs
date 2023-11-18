

Console.WriteLine("Entry the first number");
var num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
var num2 = int.Parse(Console.ReadLine());


if(num1 > num2)
    Console.WriteLine($"{num1} is greather than {num2}");
if(num1 < num2)
    Console.WriteLine($"{num2} is greather than {num1}");
if(num1 == num2)
    Console.WriteLine($"{num1} and {num2} are equals");
