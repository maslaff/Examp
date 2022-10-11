// Задача 28: Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N. 
// 4 -> 24 5 -> 120 


// Console.Write($"Ввод числа: ");
// int n = Convert.ToInt32(Console.ReadLine());
int a = 4;
int b = 5;

summ(a);
summ(b);

void summ(int n)
{
    int acc = 1;
    for (int i = 1; i <= n; i++) { acc *= i; }
    Console.WriteLine(acc);
}