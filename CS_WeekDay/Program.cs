string[] wd = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение" };

while (true)
{
    Console.Write($"Ввод числа от 1 до 7: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n <= 7 && n > 0)
    {
        Console.WriteLine($"{n} - {wd[n - 1]}");
        break;
    }
    else
    {
        Console.WriteLine($"Требуется число от 1 до 7\n");
    }
}