// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

point3d a = requestPoint3d($"Ввод A");
point3d b = requestPoint3d($"Ввод B");

double dist = Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2) + Math.Pow(a.z - b.z, 2));
Console.WriteLine($"Расстояние между A и B = {dist - dist % 0.01}");


point3d requestPoint3d(string msg)
{
    point3d point;
    Console.WriteLine(msg);
    Console.Write("X: ");
    point.x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y: ");
    point.y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Z: ");
    point.z = Convert.ToInt32(Console.ReadLine());
    return point;
}

public struct point3d
{
    public int x;
    public int y;
    public int z;
};
