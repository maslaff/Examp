// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]

Random r = new Random();
int a = 8;
int[] b = { 1, 2, 5, 7, 19 };
int[] c = { 6, 1, 33 };

printArray(getArray(a));
printArray(b);
printArray(c);


int[] getArray(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = r.Next(1, 99);
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