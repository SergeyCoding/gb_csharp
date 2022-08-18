Console.Write("Трехзначное число: ");
int x = int.Parse(Console.ReadLine());

if (x >= 100 && x <= 999)
{
    // Выведем остаток от деления на 10
    Console.WriteLine(x % 10);
}
else
    Console.WriteLine("Это не трехначное число");