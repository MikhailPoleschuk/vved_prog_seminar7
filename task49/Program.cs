// 49


int[,] FillArrayMatrix(int[,] AnyArray)
{

    for (int i = 0; i < AnyArray.GetLength(0); i++)
    {
        for (int j = 0; j < AnyArray.GetLength(1); j++)

            AnyArray[i, j] = AnyArray[i, j] = new Random().Next(0, 10);
    }
    return AnyArray;
}

int[,] ReFillArrayMatrix(int[,] AnyArray)
{
// по условию задачи оба индекса четные, однако в контрольном примере они нечетные (сделано как в контрольном примере)
    for (int i = 1; i < AnyArray.GetLength(0); i+=2)
    {
        for (int j = 1; j < AnyArray.GetLength(1); j+=2)

            AnyArray[i, j] = AnyArray[i, j] * AnyArray[i, j];
    }
    return AnyArray;
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
int[,] ArrayForReFill = new int[N, M];
ArrayForReFill = ReFillArrayMatrix(newArray);
 Console.WriteLine();
PrintArray(ArrayForReFill);