// Задача 33: Задайте массив.Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
// 4; массив[6, 7, 19, 345, 3]->нет - 3; массив[6, 7, 19, 345, 3]->да 

Random r = new Random();
// int len = 12;
int count = 0;
int num = 3;

// int[] arr = getArray(len);
int[] arr = { 6, 7, 19, 345, 3 };
printArray(arr);

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == num)
        count++;
}
Console.WriteLine(count > 0 ? "да" : "нет");


// int[] getArray(int len)
// {
//     int[] arr = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         arr[i] = r.Next(1, 99);
//     }
//     return arr;
// }

void printArray(int[] arr)
{
    Console.Write($"[{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
        Console.Write($", {arr[i]}");
    Console.WriteLine($"]");
}