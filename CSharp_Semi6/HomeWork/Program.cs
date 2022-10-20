// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3  *4. некорректный пример
int M = requestInt("Ввод количества чисел: ");
int count = 0;
for (int i = 0; i < M; i++)
    if (requestInt($"Ввод {i} числа: ") > 0) count++;
Console.WriteLine(count);


// Задача 43: Напишите программу, которая 
// найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
// int b1 = requestInt("b1: ");
// int k1 = requestInt("k1: ");
// int b2 = requestInt("b2: ");
// int k2 = requestInt("k2: ");

int b1 = 2;
int k1 = 5;
int b2 = 4;
int k2 = 9;


// ------ Methods

int requestInt(string msg)
{
    Console.Write($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] getArray(int len, int from, int to)
{
    Random r = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
        arr[i] = r.Next(from, to);
    return arr;
}

void printArray(int[] arr)
{
    Console.Write($"[{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
        Console.Write($", {arr[i]}");
    Console.WriteLine($"]");
}