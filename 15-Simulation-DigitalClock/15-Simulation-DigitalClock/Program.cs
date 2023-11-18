

for (int i = 0; i < 24; i++)
{
    for (int y = 0; y <= 59; y++)
    {
        for (int x = 0; x <= 59; x++)
        {
            Console.SetCursorPosition(25, 15);
            Console.WriteLine($"{i} : {y} : {x}");
            await Task.Delay(1000); //Is more realistic
         
        }
    }
   
}



