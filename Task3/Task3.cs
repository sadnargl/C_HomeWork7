byte [,] result = RandomFeelTwoDimensionsArray (5,5);
PrintArray (result);
Console.WriteLine ();
PrintMiddleZumInRow (result);

Byte [,] RandomFeelTwoDimensionsArray (int FirstLength, int SecondLength)
{
    Byte [,] Array = new Byte [FirstLength,SecondLength];
    Random rnd = new Random ();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
       for (int j = 0; j < Array.GetLength(1); j++)
       {
        Array [i,j]= (byte)rnd.NextInt64 (0,255);
       } 
    }
    return Array;
}

void PrintMiddleZumInRow (byte [,] Array)
{
    int columnzum;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        columnzum = 0;
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            columnzum = columnzum + Array [j,i];
        } 
        Console.Write ($"{(double)columnzum/Array.GetLength(0)} ");
    }
}

void PrintArray (byte [,] Array)
{

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
          Console.Write ($"{Array [i,j]} ");  
        }
        Console.WriteLine ();
    }
}