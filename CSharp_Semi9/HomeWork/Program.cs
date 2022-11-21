// Урок 9.Как не нужно писать код. Часть 3

// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// #define numbersNTo1Rec
#if numbersNTo1Rec

int n = 8;

numbersNTo1Rec(n);
void numbersNTo1Rec(int n)
{
    Console.Write($"{n} ");
    if (n > 1)
        numbersNTo1Rec(n - 1);
}
Console.WriteLine();

#endif


// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

// #define SumMToN
#if SumMToN

const int m = 4, n = 8;

Console.WriteLine($"Iterative: {SumMToNIte(m, n)}");
int SumMToNIte(int m, int n)
{
    int acc = 0;
    for (int i = m; i <= n; i++) acc += i;
    return acc;
}

Console.WriteLine($"Recursive: {SumMToNRec(m, n)}");
int SumMToNRec(int m, int n)
{
    if (m >= n) return n;
    return m + SumMToNRec(m + 1, n);
}

#endif


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29

#define Akkerman
#if Akkerman

int m = 2, n = 3;
// int m = 3, n = 2;
int acc = 0;
int tab = 0;
Console.WriteLine($"A({m}, {n}) = {A(m, n)} :{acc}");
int A(int m, int n)
{
    acc++;
    Console.SetCursorPosition(tab * 3, acc);
    if (m == 0)
    {
        tab--;
        Console.WriteLine($"{n + 1}");
        return n + 1;
    }
    if (m != 0 && n == 0)
    {
        tab++;
        Console.WriteLine($"A({m - 1}, 1)");
        return A(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        tab++;
        Console.WriteLine($"A({m - 1}, A({m}, {n - 1}))");
        return A(m - 1, A(m, n - 1));
    }
    tab++;
    Console.WriteLine($"** A({m}, {n})");
    return A(m, n);
}

#endif