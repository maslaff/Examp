//Задача 8: на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write($"Ввод числа: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 2;

Console.Write($"{i}\n");

while (i < n)
{
    i += 2;
    Console.Write($"{i}\n");
}
