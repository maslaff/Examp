//Задача 6. на вход принимает число и выдаёт, является ли число чётным
Console.Write($"Ввод числа: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n % 2 == 0 ? "Да" : "Нет");