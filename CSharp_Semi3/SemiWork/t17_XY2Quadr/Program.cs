// 17.  на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
//      выдаёт номер четверти плоскости, в которой находится эта точка. 

Console.Write($"Ввод X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write($"Ввод Y: ");
int y = Convert.ToInt32(Console.ReadLine());
int quart = 0;

if (x == 0 || y == 0) return;

if (x > 0)
{
    if (y > 0) quart = 1;
    else if (y < 0) quart = 2;
}

else
{
    if (y > 0) quart = 4;
    else if (y < 0) quart = 3;
}

Console.WriteLine($"Точка находится в {quart} четверти.");
