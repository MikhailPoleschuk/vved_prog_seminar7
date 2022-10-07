// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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
int[,] newArray = new int[4, 5];
newArray = FillArrayMatrix(newArray);
PrintArray(newArray);


Console.WriteLine("Введите номер строки:");
int i = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите номер столбца:");
int j = Convert.ToInt32(Console.ReadLine()) - 1;

if (i >= newArray.GetLength(0) || j >= newArray.GetLength(1) ) Console.WriteLine("такого элемента нет");
else Console.WriteLine(newArray[i, j]);


