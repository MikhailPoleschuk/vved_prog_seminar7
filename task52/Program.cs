// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillArrayMatrix(int[,] AnyArray)
{

    for (int i = 0; i < AnyArray.GetLength(0); i++)
    {
        for (int j = 0; j < AnyArray.GetLength(1); j++)

            AnyArray[i, j] = new Random().Next(1, 10); //можем регулировать в каком диапазоне создаются числа
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

double arithmeticMeanOfTheColumnArray(int[,] AnyArray, int j)
{
    double SummaOfTheColumn = 0;
    for (int i = 0; i < AnyArray.GetLength(0); i++) SummaOfTheColumn = SummaOfTheColumn + AnyArray[i, j];
    double arithmeticMeanOfTheColumn = SummaOfTheColumn / (AnyArray.GetLength(0));
    return arithmeticMeanOfTheColumn;
}

Console.Clear();
int[,] newArray = new int[4, 8];
newArray = FillArrayMatrix(newArray);
PrintArray(newArray);

for (int j = 0; j < newArray.GetLength(1); j++)
{
    double arithmeticMeanOfTheColumnJ = arithmeticMeanOfTheColumnArray(newArray, j);
    Console.Write($"{arithmeticMeanOfTheColumnJ} ");
}

