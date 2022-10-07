// 51


int[,] FillArrayMatrix(int[,] AnyArray)
{

    for (int i = 0; i < AnyArray.GetLength(0); i++)
    {
        for (int j = 0; j < AnyArray.GetLength(1); j++)

            AnyArray[i, j] = AnyArray[i, j] = new Random().Next(0, 10);
    }
    return AnyArray;
}

int SummaDiagonaliArrayMatrix(int[,] AnyArray)
{
    int SummaDiagonali = 0;
    for (int i = 0; i < AnyArray.GetLength(0); i += 1)
    {
        for (int j = 0; j < AnyArray.GetLength(1); j += 1)
            if (i == j) SummaDiagonali = SummaDiagonali + AnyArray[i, j];
    }
    return SummaDiagonali;
}


void PrintArray(int[,] AnyArray)
{
    for (int i = 0; i < AnyArray.GetLength(0); i++)
    {
        for (int j = 0; j < AnyArray.GetLength(1); j++) { Console.Write($"  {AnyArray[i, j]} "); }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M:");
int M = Convert.ToInt32(Console.ReadLine());

int[,] newArray = new int[N, M];
newArray = FillArrayMatrix(newArray);
PrintArray(newArray);
int SummaDiagonali = SummaDiagonaliArrayMatrix(newArray);
Console.WriteLine(SummaDiagonali);