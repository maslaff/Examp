// Задача 2: на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write($"Максимальное из 2х чисел\n- - - - -\n");
Console.Write($"Ввод первого числа: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"Ввод второго числа: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Max = {(a > b ? a : b)}");
Console.WriteLine();


// Задача 4: на вход три числа и выдаёт максимальное из этих чисел.
Console.Write($"Максимальное из 3х чисел\n- - - - -\n");

Console.Write($"Ввод первого числа: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write($"Ввод второго числа: ");
int read = Convert.ToInt32(Console.ReadLine());
if (read > max) { max = read; }

Console.Write($"Ввод третьего числа: ");
read = Convert.ToInt32(Console.ReadLine());
if (read > max) { max = read; }

Console.WriteLine($"Max: {max}");
Console.WriteLine();



//Задача 6. на вход принимает число и выдаёт, является ли число чётным
Console.Write($"Четное\n- - - - -\n");
Console.Write($"Ввод числа: ");
int v = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(v % 2 == 0 ? "Да" : "Нет");
Console.WriteLine();



//Задача 8: на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.Write($"Ряд четных от 1 до N\n- - - - -\n");
Console.Write($"Ввод числа: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 2;

do
{
    Console.Write($"{i}\n");
    i += 2;
} while (i <= n);
