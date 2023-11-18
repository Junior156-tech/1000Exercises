Console.Write("Digit a number, max 10: ");
int num = int.Parse(Console.ReadLine()!);

if (num == 0)
    return;

for (int i = 1; i <= 1; i++)
{
    for (int j = 0; j < 50; j++)
    {
        if (j == 49)
        {
            for (int b = 0; b < num; b++)
            {
                Console.SetCursorPosition(0, b);
                for (int y = 0; y < 50; y++)
                {
                    Console.Write("x");
                }

                Console.SetCursorPosition(0, 19 - b);
                for (int y = 0; y < 50; y++)
                {
                    Console.Write("x");
                }
            }
        }
    }

    for (int j = 0; j < 20; j++)
    {
        Console.WriteLine("x");
        Console.SetCursorPosition(50, j);
        Console.WriteLine("x");

        for (int b = 0; b < num; b++)
        {
            Console.SetCursorPosition(b, j);
            Console.WriteLine("x");
            Console.SetCursorPosition(50 - b, j);
            Console.WriteLine("x");
        }
    }
}


//int CAN, F, C, T, FI, FF, CI, CF;
//string linea;
//Console.Write("DIGITE UN NÚMERO MÁX=10: "); linea = Console.ReadLine();
//CAN = byte.Parse(linea);
//FI = 2; FF = 22;
//CI = 2; CF = 77;
//for (T = 1; T <= CAN; T++)
//{
//    for (F = CI; F <= CF; F++)
//    {
//        Console.SetCursorPosition(F, FF); Console.Write("X");
//        Console.SetCursorPosition(F, FI); Console.Write("X");
//    }
//    for (C = FI; C <= FF; C++)
//    {
//        Console.SetCursorPosition(CI, C); Console.Write("X");
//        Console.SetCursorPosition(CF, C); Console.Write("X");
//    }
//    FI = FI + 1; FF = FF - 1;
//    CI = CI + 1; CF = CF - 1;
//}
//Console.WriteLine();
