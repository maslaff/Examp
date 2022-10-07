// 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y). 

Console.Write($"Ввод четверти: ");
int quart = Convert.ToInt32(Console.ReadLine());
int x = 0;
int y = 0;

switch (quart)
{
    case 1: x = 1; y = 1; break;
    case 2: x = 1; y = -1; break;
    case 3: x = -1; y = -1; break;
    case 4: x = -1; y = 1; break;
    default: break;
}

Console.WriteLine($"X от 0 до {(x < 0 ? '-' : '+')}i\nY от 0 до {(y < 0 ? '-' : '+')}i");
