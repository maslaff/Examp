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