// 857

int[] GetArray(int num, int minValue, int maxValue)
{
    int[] res = new int[num];

    for (int i = 0; i < num; i++)
    {
        res[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col],5}");
        }

        Console.WriteLine();
    }
}


void Freq(int[] arr)
{

}

Console.Write("Количество: ");
var number = int.Parse(Console.ReadLine());
Console.WriteLine();

if (number < 1)
{
    Console.WriteLine("Ошибка! Введите корректные данные");
    return;
}

var arr = GetArray(number, 1, 9);
Console.WriteLine(string.Join(", ", arr));
Transp(arr);
Console.WriteLine();
PrintArray(arr);