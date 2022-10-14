// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3[6 7 3 6]-> 36 21 

Random r = new Random();
int len = 4;
int len_sum = len / 2 + len % 2;
int[] sum = new int[len_sum];

int[] arr = getArray(len);
printArray(arr);

for (int i = 0; i < len_sum; i++)
{
    // Console.WriteLine($"{}");
    if (i == len - i)
        sum[i] = arr[i];
    else
        sum[i] = arr[i] * arr[len - 1 - i];

}
// Console.WriteLine(count);
printArray(sum);


int[] getArray(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = r.Next(1, 9);
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