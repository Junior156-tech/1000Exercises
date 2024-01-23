Console.WriteLine("enter your phrase");
var phrase = Console.ReadLine();
int A = 0;
int E = 0;
int I = 0;
int O = 0;
int U = 0;

for (int i = 0; i < phrase!.Length; i++)
{
	switch (phrase[i])
	{
        case 'a' or 'A':
            ++A;
            break;
        case 'e' or 'E':
            ++E;
            break;
        case 'i' or 'I':
            ++I;
            break;
        case 'o' or 'O':
            ++O;
            break;
        case 'u' or 'U':
            ++U;
            break;
    }

}

Console.WriteLine("The phrase: " + phrase);
Console.WriteLine("EXISTEN {0} VOCALES A", A);
Console.WriteLine("EXISTEN {0} VOCALES E", E);
Console.WriteLine("EXISTEN {0} VOCALES I", I);
Console.WriteLine("EXISTEN {0} VOCALES O", O);
Console.WriteLine("EXISTEN {0} VOCALES U", U);
Console.Write("Pulse una Tecla:");