Console.Write($"Максимальное из 3х чисел\n- - - - -\n");
// Console.Write($"Ввод первого числа: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Ввод второго числа: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Ввод третьего числа: ");
// int c = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввод числа элементов: ");
int arrLen = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[arrLen];

for (int i = 0; i < arrLen; i++)
{
    Console.Write($"Ввод {i + 1} / {arrLen} числа: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int min = arr[0], max = arr[0];
for (int i = 0; i < arrLen; i++)
{
    if (arr[i] > max) { max = arr[i]; }
    else if (arr[i] < min) { min = arr[i]; }
}

Console.WriteLine($"Max: {max}\t Min {min}");