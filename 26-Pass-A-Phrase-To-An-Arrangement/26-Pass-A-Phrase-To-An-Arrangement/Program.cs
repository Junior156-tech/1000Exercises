Console.WriteLine("Enter a phrase");
var phrase = Console.ReadLine();
char[] phraseDivision = new char[phrase.Length];

for (int i = 0; i < phrase.Length; i++)
{
   var charFirst = phrase[i]; 
    phraseDivision[0] = charFirst;
    Console.WriteLine(phraseDivision);
}