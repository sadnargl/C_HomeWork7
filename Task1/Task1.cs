int FirstDimension = InputFigureFromConsole ("Введите первое измерение массива: ");
int SecondDimension = InputFigureFromConsole ("Введите второе измерение массива: ");
if (FirstDimension == -1 | SecondDimension == -1)
    { 
    Console.WriteLine ("Число введено с ошибкой");
    System.Environment.Exit (0);
    }
Double [,] result = RandomFeelTwoDimensionsArray (FirstDimension,SecondDimension);
PrintArray (result);

Double [,] RandomFeelTwoDimensionsArray (int FirstLength, int SecondLength)
{
    Double [,] Array = new Double [FirstLength,SecondLength];
    Random rnd = new Random ();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
       for (int j = 0; j < Array.GetLength(1); j++)
       {
        Array [i,j]= Math.Round(rnd.NextDouble ()*10, 2);
       } 
    }
    return Array;
}

void PrintArray (double [,] Array)
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

int InputFigureFromConsole (string invitation)
{
    Console.Write (invitation);
    int i;
    while (!int.TryParse (Console.ReadLine(), out i))
    {
        Console.WriteLine ("Ошибка ввода числа");
        Console.Write (invitation);
    }
    if (i>=1) {return i;} else {return -1;}
}

