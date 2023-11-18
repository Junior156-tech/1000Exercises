
Console.WriteLine("Entry the first number");
var num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
var num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the third number");
var num3 = int.Parse(Console.ReadLine());



//Search the greather number
if (num1 > num2 && num1 > num3)
    Console.WriteLine($"{num1} is greather");
else if (num2 > num1 && num2 > num3)
    Console.WriteLine($"{num2} is greather");
else if (num3 > num1 && num3 > num2)
    Console.WriteLine($"{num3} is greather");

//Search two equals numbers / 3
if (num1 == num2 && num1 > num3)
    Console.WriteLine($"{num1} and {num2} is greather");
else if (num2 > num1 && num2 == num3)
    Console.WriteLine($"{num3} and {num2} is greather");
else if (num3 == num1 && num3 > num2)
    Console.WriteLine($"{num1} and {num3} is greather");


//Search the smaller number
if (num1 < num2 && num1 < num3)
    Console.WriteLine($"{num1} is smaller");
else if (num2 < num1 && num2 < num3)
    Console.WriteLine($"{num2} is smaller");
else if (num3 < num1 && num3 < num2)
    Console.WriteLine($"{num3} is smaller");


//Search the middle number
if (num1 < num2 && num1 > num3)
    Console.WriteLine($"{num1} is middle");
else if (num2 < num1 && num2 > num3)
    Console.WriteLine($"{num2} is middle");
else if (num3 < num1 && num3 > num2)
    Console.WriteLine($"{num3} is middle");
else if (num1 > num2 && num1 < num3)
    Console.WriteLine($"{num1} is middle");
else if (num2 > num1 && num2 < num3)
    Console.WriteLine($"{num2} is middle");
else if (num3 > num1 && num3 < num2)
    Console.WriteLine($"{num3} is middle");

if (num1 == num2 && num2 == num3)
    Console.WriteLine("All the numbers are equals");