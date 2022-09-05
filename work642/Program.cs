string ToBinary(int number)
{
    if (number == 0) return "0";
    if (number == 1) return "1";
    return ToBinary(number / 2) + number % 2;
}

string ToBinaryCycle(int number)
{
    if (number == 0) return "0";

    string result = string.Empty;

    while (number > 0)
    {
        result = number % 2 + result;
        number = number / 2;
    }

    return result;
}

Console.Write("Число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(ToBinary(number));
Console.WriteLine(ToBinaryCycle(number));

