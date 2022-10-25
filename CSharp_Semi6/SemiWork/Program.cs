// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.) 
// [1 2 3 4 5] -> [5 4 3 2 1][6 7 3 6] -> [6 3 7 6]
void ReverseArray()
{
    int[] array = { 1, 2, 3, 4, 5, 6 };

    int tmp = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }

    // int[] targetArray = new int[array.Length];
    // for (int i = 0; i < array.Length; i++)
    //     targetArray[i] = array[array.Length - 1 - i];
    // array = targetArray;

    System.Console.WriteLine($"{IntArrayToString(array, array.Length)}");
}
ReverseArray();


// Задача 40: Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины. 
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон 

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
// 45 -> 101101 3 -> 11 2 -> 10 

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5-> 0 1 1 2 3 Если N = 3-> 0 1 1 Если N = 7 -> 0 1 1 2 3 5 8 

void fibonacci(int N)
{
    int num = 1;
    int acc = 0;
    int tmp;
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{acc} ");
        tmp = acc;
        acc += num;
        num = tmp;
    }
    Console.WriteLine();
}
// fibonacci(12);

void fibonacciArr(int N)
{
    int[] fib = new int[N];
    fib[0] = 0;
    fib[1] = 1;
    for (int i = 1; i < N - 1; i++)
    {
        fib[i + 1] = fib[i] + fib[i - 1];
    }
    printArray(fib);
}
// fibonacciArr(12);


// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. 
int[] copyArray(int[] arr)
{
    int[] arr2 = new int[arr.Length];
    printArray(arr);
    for (int i = 0; i < arr.Length; i++)
        arr2[i] = arr[i];
    return arr2;
}
// printArray(copyArray(getArray(5, 1, 100)));


void printArray(int[] arr)
{
    Console.Write($"[{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
        Console.Write($", {arr[i]}");
    Console.WriteLine($"]");
}

string IntArrayToString(int[] arr, int to)
{
    string str = $"[{arr[0]}";
    for (int i = 1; i < to; i++)
        str += $", {arr[i]}";
    return str + ']';
}

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
