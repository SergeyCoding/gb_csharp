
Console.Write("Число: ");
int x = int.Parse(Console.ReadLine());

if (x < 0)
    x = -x;

int s = -x;

while (s <= x)
{
    Console.Write(s);

    if (s != x)
        Console.Write(", ");

    s++;
}
