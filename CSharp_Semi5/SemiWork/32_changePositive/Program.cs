// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот. 
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();
int[] array = new int[4];
int[] array_invert = new int[4];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 100);
    Console.Write(array[i] + " ");
}

Console.WriteLine("");

for (int i = 0; i < array.Length; i++)
{
    array_invert[i] = array[i] * -1;
    Console.Write(array_invert[i] + " ");
}