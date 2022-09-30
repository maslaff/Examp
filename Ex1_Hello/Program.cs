Console.Write($"Ввод первого числа: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Ввод второго числа: ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 == n2 * n2)
{
    Console.WriteLine($"Число {n1} является квадратом числа {n2}");
}
else
{
    Console.WriteLine($"Число {n1} НЕ является квадратом числа {n2}");
}