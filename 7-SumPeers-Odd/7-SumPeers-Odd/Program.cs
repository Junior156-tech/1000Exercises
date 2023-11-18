
Console.WriteLine("Enter your number");
int num = int.Parse(Console.ReadLine()!);


List<int> arrayPeers = new List<int>();
List<int> arrayOdd = new List<int>();

for (int i = 1; i <= num; i++)
{
    if(i % 2 == 0)
    {
        arrayOdd.Add(i);
    }
    else { arrayPeers.Add(i); }
}

var result1 = arrayOdd.Sum(x => x);
var result2 = arrayPeers.Sum(x => x);

Console.WriteLine($"Sum of Odd {result1}");
Console.WriteLine($"Sum of Peers {result2}");

