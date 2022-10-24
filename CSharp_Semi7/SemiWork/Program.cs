// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами. 
// m = 3, n = 4. 1 4 8 19 5 -2 33 -2 77 3 8 1 
// print2DArray(Get2DArray(3, 4, -10, 99));


// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m + n.
// Выведите полученный массив на экран. 
// m = 3, n = 4. 0 1 2 3 1 2 3 4 2 3 4 5 
// int m = 3, n = 4;
// int[,] arr = new int[m, n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         arr[i, j] = i + j;
//         Console.Write($"{arr[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так: 1 4 7 2 5 9 2 3 8 4 2 4 
// Новый массив будет выглядеть вот так: 1 4 7 2 5 81 2 9 8 4 2 4 



// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1; 1) и т.д.
// Например, задан массив: 1 4 7 2 5 9 2 3 8 4 2 4 Сумма элементов главной диагонали: 1+9+2 = 12 
int m = 5, n = 4;
int sum = 0;
int[,] arr = Get2DArray(m, n, 1, 10);
print2DArray(arr);
Console.WriteLine();
for (int i = 0; i < m && i < n; i++)
{
    sum += arr[i, i];
}
Console.WriteLine($"{sum}");


// ------ Methods

int[,] Get2DArray(int m, int n, int from, int to)
{
    Random r = new Random();
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            arr[i, j] = r.Next(from, to);
    return arr;
}

void print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}