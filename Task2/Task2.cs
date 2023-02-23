int FirstDimension = InputFigureFromConsole ("Введите первое измерение: ");
int SecondDimension = InputFigureFromConsole ("Введите второе измерение: ");
if (FirstDimension == -1 | SecondDimension == -1)
    { 
    Console.WriteLine ("Число введено с ошибкой");
    System.Environment.Exit (0);
    }
byte [,] result = RandomFeelTwoDimensionsArray (5,5);
PrintArray (result);
FindArrayElement (result, FirstDimension, SecondDimension);

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

void FindArrayElement (byte [,] Array, int dim1, int dim2)
{
 if (Array.GetLength(0)>dim1 && Array.GetLength(1)>dim2)
 {
    Console.WriteLine (Array[dim1-1,dim2-1]);
 }
 else
 {
   Console.WriteLine ("Position is out of range"); 
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