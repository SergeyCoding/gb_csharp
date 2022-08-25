Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int n = 1;

while (n <= number)
{
    Console.Write(n * n);

    if (n < number)
        Console.Write(", ");

    n++;
}

Console.WriteLine();