// Задача 10: 
// На вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write($"Ввод трехзначного числа: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 100 || n >= 1000)
{
    Console.WriteLine("Нужно трехзначное число");
    return;
}

// Console.WriteLine(n / 100 * 10 + n % 10); // Две крайние цифры
Console.WriteLine(n / 10 % 10); // Вторая цифра