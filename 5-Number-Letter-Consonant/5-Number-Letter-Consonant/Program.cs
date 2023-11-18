

Console.WriteLine("Enter a character");
char result = char.Parse(Console.ReadLine()!);

Console.WriteLine(result);

switch (result)
{
	case 'a':
	case 'e':
	case 'i':
	case 'o':
	case 'u':
        Console.WriteLine("It's vocal ");
		break;
    case '1':
    case '2':
    case '3':
    case '4':
    case '5':
    case '6':
    case '7':
    case '8':
    case '9':
        Console.WriteLine("It's number ");
        break;
    default:
        Console.WriteLine("It's consonant");
        break;
}