// Задача 30: Напишите программу, которая 
// выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. 
// [1,0,1,1,0,1,0,0]

Random r = new Random();
int[] arrByte = new int[8];

Console.Write('[');
for (int i = 0; i < arrByte.Length; i++)
{
    arrByte[i] = rand();
    Console.Write($"{arrByte[i]},");
}
Console.WriteLine(']');

int rand()
{
    return r.Next(0, 2);
}

// Console.WriteLine("[{0}]", string.Join(", ", arrByte));