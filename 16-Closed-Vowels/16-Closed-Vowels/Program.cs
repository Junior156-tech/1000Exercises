Console.WriteLine("enter your phrase");
var phrase = Console.ReadLine();
int count = 0;
for (int i = 0; i < phrase!.Length; i++)
{
    if (phrase[i] == 'a' || phrase[i] == 'e' || phrase[i] == 'o')
        count++;
}


Console.WriteLine("The phrase: " + phrase );
Console.WriteLine("Contain " + count  + " closed vowels");