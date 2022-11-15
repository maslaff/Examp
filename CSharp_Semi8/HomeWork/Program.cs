// Урок 8.Как не нужно писать код. Часть 2

// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// #define SortingArrayRows
#if SortingArrayRows

int[,] arr = Get2DIntArray(3, 4);
Print2DArray(arr, ' ');

for (int row = 0; row < arr.GetLength(0); row++)
{
    for (int col = 0; col < arr.GetLength(1); col++)
    {
        for (int i = col + 1; i < arr.GetLength(1); i++)
        {
            if (arr[row, i] > arr[row, col])
            {
                int tmp = arr[row, col];
                arr[row, col] = arr[row, i];
                arr[row, i] = tmp;
            }
        }
    }
}
Print2DArray(arr, ' ');

#endif



// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// #define FindMinSumRow
#if FindMinSumRow

int rows = 5, cols = 4;
FindMinSumRow(rows, cols);
void FindMinSumRow(int rows, int cols)
{
    int[,] arr = Get2DIntArray(rows, cols);
    Print2DArray(arr, ' ');
    int minSumRow = FindMin(GetRowsSumms(arr));
    Console.WriteLine($"Программа считает сумму элементов в каждой строке и выдаёт номер [первой найденной] строки с наименьшей суммой элементов: {minSumRow + 1} строка");
}

int[] GetRowsSumms(int[,] arr)
{
    int[] summsArr = new int[rows];

    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int col = 0; col < arr.GetLength(1); col++)
        {
            summsArr[row] += arr[row, col];
        }
    }
    return summsArr;
}

int FindMin(int[] arr)
{
    int min = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[i - 1]) min = i;
    }
    return min;
}
#endif



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// #define ProdMatrix
#if ProdMatrix

int rowsA = 3, colsA = 4;
int rowsB = 4, colsB = 3;
if (colsA == rowsB)
{
    int[,] arrA = Get2DIntArray(rowsA, colsA);
    int[,] arrB = Get2DIntArray(rowsB, colsB);
    Print2DArray(arrA);
    Print2DArray(arrB);
    Print2DArray(ProdMatrix(arrA, arrB));
}
else Console.WriteLine("Matrix multiply impossible");

int[,] ProdMatrix(int[,] arrA, int[,] arrB)
{
    int rowsA = arrA.GetLength(0);
    int colsB = arrB.GetLength(1);
    int[,] resultArray = new int[rowsA, colsB];
    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < colsB; j++)
        {
            for (int k = 0; k < arrA.GetLength(1); k++)
                resultArray[i, j] += arrA[i, k] * arrB[k, j];
        }
    }
    return resultArray;
}
#endif


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)

// #define Print3dArray
#if Print3dArray

int x = 2, y = 2, z = 2;
Random r = new Random();
int[,,] arr = new int[x, y, z];

int[] list = new int[x * y * z];
int item = 0;
while (item < list.Length)
{
    int newNum = r.Next(10, 100);
    if (NumInArray(newNum, list, item))
        continue;
    list[item] = newNum;
    item++;
}

item = 0;
for (int i = 0; i < x; i++)
    for (int j = 0; j < y; j++)
        for (int k = 0; k < z; k++)
        {
            arr[i, j, k] = list[item];
            item++;
        }

for (int zpos = 0; zpos < z; zpos++)
{
    for (int row = 0; row < y; row++)
    {
        Console.WriteLine();
        for (int col = 0; col < x; col++)
        {
            System.Console.Write($"{arr[row, col, zpos]}({row}, {col}, {zpos}) ");
        }
    }
}
Console.WriteLine();

bool NumInArray(int num, int[] arr, int toPos)
{
    for (int j = 0; j < toPos - 1; j++)
        if (num == arr[j])
            return true;
    return false;
}

#endif

// Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

#define FillArraySpirally
#if FillArraySpirally

int sizeX = 4, sizeY = 4;
int[,] arr = new int[sizeX, sizeY];

int row = 0, col = 0;
for (int num = 1; num <= sizeX * sizeY; num++)
{
    arr[row, col] = num;
    if (row <= col + 1 && row + col < sizeY - 1) col++;
    else if (row < col && row + col >= sizeX - 1) row++;
    else if (row >= col && row + col > sizeY - 1) col--;
    else row--;
}

for (int i = 0; i < sizeX; i++)
{
    for (int j = 0; j < sizeY; j++)
    {
        if (arr[i, j] < 10) Console.Write('0');
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
}

#endif


#if SortingArrayRows || FindMinSumRow || ProdMatrix
// ------ Methods
/// Даёт массив случайных целых чисел, от min до max, размером rows X cols.
int[,] Get2DIntArray(int rows, int cols, int min = 1, int max = 9)
{
    Random r = new Random();
    int[,] arr = new int[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            arr[i, j] = r.Next(min, max);
    return arr;
}

void Print2DArray(int[,] arr, char sep = ' ')
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]}{sep}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

#endif