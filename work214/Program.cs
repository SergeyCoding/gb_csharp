System.Console.Write("Число: ");
int x = int.Parse(Console.ReadLine());

if (x % 7 == 0 && x % 23 == 0)
    System.Console.WriteLine("да");
else
    System.Console.WriteLine("нет");