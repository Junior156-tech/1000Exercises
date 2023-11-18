Console.WriteLine("Digit a password");
var password = Console.ReadLine();
var verifyPassword = password;
int count = 3;
while (count > 0)
{
    Console.Write("Enter you password: ");
    var verifyPw = Console.ReadLine();
    if (verifyPw == password)
    {
        Console.WriteLine();
        Console.WriteLine("Password correct");
        break;
    }
    else
    {
        Console.WriteLine("Passowrd incorrect");
        count--;
    }
}