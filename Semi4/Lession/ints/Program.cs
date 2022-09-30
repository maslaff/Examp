Console.Write($"Ввод положительного числа: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = n - n * 2;
// int i = -2;
Console.Write($"{i}\n");
while (i < n)
{
    i++;
    Console.Write($"{i}\n");
}
