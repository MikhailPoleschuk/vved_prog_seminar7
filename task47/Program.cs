// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


//Fill Array-Matrix
double[,] FillArrayMatrix(double[,] AnyArray)
{
    double Random1 = 0;
    double Random2 = 0;
    for (int i = 0; i < AnyArray.GetLength(0); i++)
    {
        for (int j = 0; j < AnyArray.GetLength(1); j++)
        {
            // не знаю операторов которые выдают случайные вещественные числа, вот решил просто формулой задать
            Random1 = new Random().Next(-15, 115);
            Random2 = new Random().Next(1, 5);
            AnyArray[i, j] = Random1 / Random2; 
        }
      
    }
    return AnyArray;
}

void PrintArray(double[,] AnyArray)
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

double[,] newArray = new double[N, M];
newArray = FillArrayMatrix(newArray);

PrintArray(newArray);

