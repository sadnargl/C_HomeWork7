int x1 = InputFigureFromConsole ("Введите первое число: ");
int x2 = InputFigureFromConsole ("Введите второе число: ");
long res = x1;
for (int j = 1; j <= x2-1; j++)
{
    res = res * x1;
}
Console.WriteLine ($"{x1} в степени {x2} равняется {res}");

int InputFigureFromConsole (string invitation)
{
    Console.Write (invitation);
    int i;
    while (!int.TryParse (Console.ReadLine(), out i))
    {
        Console.WriteLine ("Ошибка ввода числа");
        Console.Write (invitation);
    }
    return i;
}


