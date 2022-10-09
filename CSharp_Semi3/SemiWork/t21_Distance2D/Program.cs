// 21:  на вход координаты двух точек и 
//      находит расстояние между ними в 2D пространстве. 
//      A (3,6); B(2, 1)-> 5,09 A(7, -5); B(1, -1)-> 7,21 

point2d a;
point2d b;

a.x = requestInt($"Ввод Ax");
a.y = requestInt($"Ввод Ay");
b.x = requestInt($"Ввод Bx");
b.y = requestInt($"Ввод By");

double dist = Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
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
};
