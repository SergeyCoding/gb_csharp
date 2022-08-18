Console.Write("Введите число: ");

var number = int.Parse(Console.ReadLine() ?? string.Empty);
var sqr = number * number;
Console.WriteLine($"Результат = {sqr}");
Console.WriteLine($"Результат = {Math.Pow(number, 2)}");


