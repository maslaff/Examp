Console.Write($"Ввод первого числа: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"Ввод второго числа: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Max = {(a > b ? a : b)}");