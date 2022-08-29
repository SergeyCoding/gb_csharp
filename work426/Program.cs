int DigitsNumber(int number)
{
    return (int)Math.Log10(number) + 1;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"{DigitsNumber(num)}");