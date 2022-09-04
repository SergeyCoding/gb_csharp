int x = new Random().Next(100, 1000);

int a1 = x / 100; // первое число
int a2 = x % 10; // последнее число

int res = a1 * 10 + a2;

Console.WriteLine($"{x} -> {res}");

// Ок?

