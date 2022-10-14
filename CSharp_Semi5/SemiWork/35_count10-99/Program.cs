// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123 [5, 18, 123, 6, 2] -> 1[1, 2, 3, 6, 2]-> 0[10, 11, 12, 13, 14]-> 5 


Random r = new Random();
int len = 123;
int count = 0;

int[] arr = getArray(len);
printArray(arr);

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] >= 10 && arr[i] <= 99)
        count++;
}
Console.WriteLine(count);


int[] getArray(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = r.Next(1, 999);
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