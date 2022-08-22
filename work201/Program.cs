// Console.Write("Двузначное число: ");
// int x = int.Parse(Console.ReadLine());
int x = new System.Random().Next(10, 100);

int a1 = x / 10;
int a2 = x % 10;

int max = a1;
if (max < a2) max = a2;

System.Console.WriteLine($"{x} -> {max}");