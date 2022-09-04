Console.Write("Введите четверть: ");
int quarta = int.Parse(Console.ReadLine());

if (quarta < 1 || quarta > 4)
{
    Console.WriteLine("Ошибка! Число должно быть в диапазоне 1-4");
}
else
{
    if (quarta == 1)
        Console.WriteLine("x > 0 && y > 0");
    else if (quarta == 2)
        Console.WriteLine("x < 0 && y > 0");
    else if (quarta == 3)
        Console.WriteLine("x < 0 && y < 0");
    else
        Console.WriteLine("x > 0 && y < 0");
}
