Console.WriteLine("Enter your phrase");
var phrase = Console.ReadLine();
var reverse = 1;
var count = phrase.Length;
while (phrase != null)
{
   
    Console.Write(phrase[phrase.Length - reverse]); 

    if(count > 0)
    {
        count--;
        reverse++;
    }
    if (count == 0)
        break;
}