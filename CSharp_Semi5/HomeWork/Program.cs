// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("-----\n34: Количество чётных чисел в массиве");
void countEvenNum()
{
    int[] arr = getArray(4, 100, 1000);
    int count = 0;
    printArray(arr);
    foreach (var item in arr)
        if (item % 2 == 0) count++;
    Console.WriteLine(count);
}
countEvenNum();

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0
Console.WriteLine("-----\n36: Сумма элементов, стоящих на нечётных позициях");
void sumNumOnEvenPos(int len)
{
    int[] arr = getArray(len, -99, 99);
    int sum = 0;
    printArray(arr);
    for (int i = 1; i < len; i += 2)
        sum += arr[i];
    Console.WriteLine(sum);
}
sumNumOnEvenPos(4);


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.WriteLine("-----\n38: Разница между максимальным и минимальным элементом массива");
void diffMinMax(int len)
{
    int[] arr = getArray(len, 1, 99);
    printArray(arr);
    int min = arr[0], max = arr[0];
    for (int i = 1; i < len; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine(max - min);
}
diffMinMax(5);


// ------ Methods

// int requestInt(string msg)
// {
//     Console.Write($"{msg}: ");
//     return Convert.ToInt32(Console.ReadLine());
// }

int[] getArray(int len, int from, int to)
{
    Random r = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = r.Next(from, to);
    }
    return arr;
}

void printArray(int[] arr)
{
    Console.Write($"[{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
        Console.Write($", {arr[i]}");
    Console.WriteLine($"]");
}