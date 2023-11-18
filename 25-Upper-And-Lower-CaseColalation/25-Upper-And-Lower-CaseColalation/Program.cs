
Console.WriteLine("Enter your phrase");
var phrase = Console.ReadLine();
string newPhrase = string.Empty;

phrase = phrase.Replace('a', 'A').Replace('e', 'E').Replace('i', 'I').Replace('o', 'O').Replace('u', 'U');
Console.WriteLine(phrase);

