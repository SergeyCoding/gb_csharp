Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int GetNums(int number)
{
    int sum = 0;

    for (int i = 0; i < number; i++)
        sum += i;

    return sum;
}

System.Console.WriteLine($"{GetNums(num)}");