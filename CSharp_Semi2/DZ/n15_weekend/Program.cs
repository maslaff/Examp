// Задача 15: 
// На вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

string[] wd = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение" };

while (true)
{
    Console.Write($"Ввод числа от 1 до 7: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n > 7 || n <= 0) { Console.WriteLine($"Требуется число от 1 до 7\n"); continue; }

    else if (n == 6 || n == 7)
    {
        Console.WriteLine($"да _ {wd[n - 1]} - Выходной день");
    }
    else
    {
        Console.WriteLine($"нет _ {wd[n - 1]} - Будний день");
    }
    return;
}