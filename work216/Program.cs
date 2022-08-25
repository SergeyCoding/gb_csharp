System.Console.Write("Первое число:");
int x1 = int.Parse(Console.ReadLine());
System.Console.Write("Второе число:");
int x2 = int.Parse(Console.ReadLine());

if (x1 * x1 == x2 || x1 == x2 * x2)
    System.Console.WriteLine("да");
else
    System.Console.WriteLine("нет");