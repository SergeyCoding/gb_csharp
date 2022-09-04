Console.Write("Первое число:");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Второе число:");
int x2 = int.Parse(Console.ReadLine());

if (x1 * x1 == x2 || x1 == x2 * x2)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");