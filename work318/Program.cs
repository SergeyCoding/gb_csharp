Console.Write("Введите четверть: ");
int quarta = int.Parse(Console.ReadLine());

if (quarta < 1 || quarta > 4)
{
    System.Console.WriteLine("Ошибка! Число должно быть в диапазоне 1-4");
}
else
{
    if (quarta == 1)
        System.Console.WriteLine("x > 0 && y > 0");
    else if (quarta == 2)
        System.Console.WriteLine("x < 0 && y > 0");
    else if (quarta == 3)
        System.Console.WriteLine("x < 0 && y < 0");
    else
        System.Console.WriteLine("x > 0 && y < 0");
}
