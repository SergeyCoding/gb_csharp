Console.Write("Введите 1 число: ");

// С терминала мы вводим строку, но надо присвоить значение в целую переменную
// этто делает parse

int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите 2 число: ");
int x2 = int.Parse(Console.ReadLine());

if (x1 == x2 * x2)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

//Все ок?

