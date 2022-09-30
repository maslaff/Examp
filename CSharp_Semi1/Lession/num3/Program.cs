Console.Write($"Ввод трехзначного числа: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 100 && n < 1000) // Проверка на трехзначность
{
    Console.Write($"{n % 10}\n"); // Выводим остаток от деления
}
else
{
    Console.WriteLine($"Требуется трехзначное число");
}

