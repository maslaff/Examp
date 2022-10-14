// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива. 
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20. 

Console.Clear();
int sum = 0;
int minus = 0;
int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write(array[i] + " ");
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum = sum + array[i];
    }
    if (array[i] < 0)
    {
        minus = minus + array[i];
    }
}

Console.WriteLine("Сумма положит чисел: " + sum);
Console.WriteLine("Сумма отрицат чисел: " + minus);