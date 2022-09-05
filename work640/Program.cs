bool IsExistTriangle(int a, int b, int c)
{
    if (a <= 0 || b <= 0 || c <= 0)
        return false;

    return a < b + c && b < a + c && c < a + b;
}

Console.Write("Ведите три числа: ");
string[] triangleSides = Console.ReadLine().Split();
int a = int.Parse(triangleSides[0]);
int b = int.Parse(triangleSides[1]);
int c = int.Parse(triangleSides[2]);

Console.WriteLine($"{a}, {b}, {c}");

if (IsExistTriangle(a, b, c))
    Console.WriteLine("да");
else
    Console.WriteLine("нет");