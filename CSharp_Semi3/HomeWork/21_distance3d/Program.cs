// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

point2d a;
point2d b;

a.x = requestInt($"Ввод Ax");
a.y = requestInt($"Ввод Ay");
a.z = requestInt($"Ввод Az");
b.x = requestInt($"Ввод Bx");
b.y = requestInt($"Ввод By");
b.z = requestInt($"Ввод Bz");

double dist = Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2) + Math.Pow(a.z - b.z, 2));
Console.WriteLine($"Расстояние между A и B = {dist - dist % 0.01}");


int requestInt(string msg)
{
    Console.Write(msg + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

public struct point2d
{
    public int x;
    public int y;
    public int z;
};
