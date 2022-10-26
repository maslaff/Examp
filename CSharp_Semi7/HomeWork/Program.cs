// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] arr = Get2DDoubleArray(3, 4, -10, 10); // Задали массив. Готово
Console.WriteLine("массив заполненный случайными вещественными числами");
print2DDoubleArray(arr);
Console.WriteLine("\n");

double[,] Get2DDoubleArray(int m, int n, int from, int to)
{
    Random r = new Random();
    double[,] arr = new double[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            arr[i, j] = Math.Round(r.NextDouble() * (to - from) - to, 1);
    return arr;
}

void print2DDoubleArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]}\t");
        Console.WriteLine();
    }
}




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

// Поиск позиции по значению
FindAndPrint();
void FindAndPrint()
{
    int num = 8; // искомое
    int[,] intArray = Get2DIntArray(3, 4, 0, 10);
    int row = 0, col = 0;
    print2DArray(intArray);
    Console.WriteLine("------------");
    Console.WriteLine(FindNumInArray(intArray, num, out row, out col)
                                ? $"{num} в позиции: {row + 1},{col + 1}"
                                : $"числа {num} в массиве нет"
                            );
    Console.WriteLine("\n");
}

bool FindNumInArray(int[,] arr, int num, out int posRow, out int posCol)
{
    posRow = 0;
    posCol = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] == num)
            {
                posRow = i;
                posCol = j;
                return true;
            }
    return false;
}

// Поиск позиции и вывод значения
FindPosInArray();
void FindPosInArray()
{
    int[,] arr = Get2DIntArray(5, 4, 0, 10);
    int row = 3;
    int col = 4;
    print2DArray(arr);
    Console.WriteLine("------------");
    if (row > arr.GetLength(0) || col > arr.GetLength(1))
        Console.WriteLine("такой позиции в массиве нет");
    else
        Console.WriteLine($"В позиции {row},{col}: {arr[row - 1, col - 1]}");
    Console.WriteLine("\n");
}





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

average();
void average()
{
    int[,] intArray = Get2DIntArray(3, 4, 0, 10);
    double[] avg = new double[intArray.GetLength(1)];
    Console.WriteLine("Среднее арифметическое каждого столбца");
    print2DArray(intArray);
    for (int col = 0; col < intArray.GetLength(1); col++)
    {
        for (int row = 0; row < intArray.GetLength(0); row++)
        {
            avg[col] += intArray[row, col];
        }
        avg[col] = Math.Round(avg[col] / intArray.GetLength(0), 1);
    }
    Console.WriteLine("------------");
    for (int i = 0; i < avg.Length; i++)
        Console.Write($"{avg[i]}\t");
    Console.WriteLine("");
}




// ------ Methods

int[,] Get2DIntArray(int m, int n, int min, int max)
{
    Random r = new Random();
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            arr[i, j] = r.Next(min, max);
    return arr;
}

void print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]}\t");
        Console.WriteLine();
    }
}