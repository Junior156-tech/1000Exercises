Console.WriteLine("Enter side 1");
var side1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter side 2");
var side2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter side 3");
var side3 = int.Parse(Console.ReadLine()!);

if(side1 == side2 && side2 == side3)
{
    Console.WriteLine("The triangle is equilatero");
}
//if((side1 == side2 && side1 != side3 && side2 != side3) || (side2 == side3 && side2 != side1 && side3 != side1) || (side3 == side1 && side3 != side2 && side3 != side2))
//{
//    Console.WriteLine("The triangle is isosceles");
//}
if (side1 != side2 && side2 != side3 && side1 != side3)
{
    Console.WriteLine("The triangle is escaleno");
}
else
{ 
    Console.WriteLine("The triangle is isosceles");
}
