// 46
//Fill Array-Matrix
int[,] FillArrayMatrix(int[,] AnyArray)
{

    for (int i = 0; i < AnyArray.GetLength(0); i++)
    {
        for (int j = 0; j < AnyArray.GetLength(1); j++)

            AnyArray[i, j] = new Random().Next(-9, 10); //можем регулировать в каком диапазоне создаются числа
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

