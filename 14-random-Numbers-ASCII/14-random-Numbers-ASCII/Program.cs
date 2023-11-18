using System.Text;

Console.WriteLine("enter your number");
int num = int.Parse(Console.ReadLine()!);

Random rand = new Random();


for (int i = 0; i < num; i++)
{
    var result = rand.Next(256);
    //var result2 = char.ConvertFromUtf32(result);

    Console.WriteLine("Number: " + result);

    if (result > 0 && result < 256)
    {
        var resultString = Convert.ToString((char)result);
            Console.WriteLine("ASCII: " + resultString);
    }

    //Console.WriteLine("ASCII " + result2);
}

