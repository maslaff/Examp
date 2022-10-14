// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

int A = req("Число");
int B = req("в степени");
int acc = A;

for (int i = 1; i < B; i++)
    acc *= A;

Console.WriteLine($"= {acc}");

int req(string msg)
{
    Console.Write($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}