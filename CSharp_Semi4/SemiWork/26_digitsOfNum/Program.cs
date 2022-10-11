// Задача 26: Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе. 
// 456 -> 3 78 -> 2 89126 -> 5 

int a = 456;
int b = 78;
int c = 89126;

Console.WriteLine(digOfNum(a));
Console.WriteLine(digOfNum(b));
Console.WriteLine(digOfNum(c));

int digOfNum(int num)
{
    int count = 0;
    while (num > 0) { num /= 10; count++; }
    return count;
}