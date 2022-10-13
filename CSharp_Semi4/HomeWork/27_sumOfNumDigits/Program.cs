// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int a = 452;
int b = 82;
int c = 9012;

Console.WriteLine(sumDigOfNum(a));
Console.WriteLine(sumDigOfNum(b));
Console.WriteLine(sumDigOfNum(c));

int sumDigOfNum(int num)
{
    int acc = 0;
    while (num > 0)
    {
        acc += num % 10;
        num /= 10;
    }
    return acc;
}