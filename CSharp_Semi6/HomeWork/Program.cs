// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3  *4. некорректный пример
void countPositive()
{
    const int maxSize = 100;
    int[] numArray = new int[maxSize];
    string input = "";
    int i = 0;
    int iGreatZero = 0;
    Console.WriteLine($"Введите до {maxSize} чисел. [end] для завершения");
    while (i < maxSize)
    {
        Console.Write($"Число {i + 1}: ");
        input = Console.ReadLine();
        int num;
        if (int.TryParse(input, out num))
        {
            numArray[i] = num;
            if (num > 0) iGreatZero++;
            if (i++ >= maxSize) break;
        }
        else if (input == "end") break;
        else Console.WriteLine($"{input} не число");
    }
    Console.WriteLine($"В массиве {printArray(numArray, i)} - {iGreatZero} положительных чисел");
}
// countPositive();


// Тут есть что доработать, но чисто как вариант конецепции
void countPositiveV2()
{
    int M = requestInt("Ввод количества чисел: ");
    int count = 0;
    for (int i = 0; i < M; i++)
        if (requestInt($"Ввод {i} числа: ") > 0) count++;
    Console.WriteLine(count);
}
// countPositiveV2();

// Задача 43: Напишите программу, которая 
// найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
void intersection()
{
    // double b1 = 2, k1 = 5;
    // double b2 = 4, k2 = 9;
    double b1 = requestInt("b1: ");
    double k1 = requestInt("k1: ");
    double b2 = requestInt("b2: ");
    double k2 = requestInt("k2: ");

    if (k1 == k2 && b1 == b2) System.Console.WriteLine("Прямые совпадают");
    else if (k1 == k2) System.Console.WriteLine("Прямые не пересекаются");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Пересечение в точке x={x}, y={y}");
    }
}
intersection();


// ------ Methods

int requestInt(string msg)
{
    Console.Write($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}

string printArray(int[] arr, int to)
{
    string str = $"[{arr[0]}";
    for (int i = 1; i < to; i++)
        str += $", {arr[i]}";
    return str + ']';
}