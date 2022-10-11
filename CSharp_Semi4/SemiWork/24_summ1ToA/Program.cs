// Задача 24: Напишите программу, которая принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А. 
// 7 -> 28 4 -> 10 8 -> 36 

// Console.Write($"Ввод числа: ");
// int n = Convert.ToInt32(Console.ReadLine());
int a = 7;
int b = 4;
int c = 8;

summ(a);
summ(b);
summ(c);

void summ(int n)
{
    int acc = 0;
    for (int i = 1; i <= n; i++) { acc += i; }
    Console.WriteLine(acc);
}