// 855

int[,] GetArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] res = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
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

void Transp(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            var temp = arr[j, i];
            arr[j, i] = arr[i, j];
            arr[i, j] = temp;
        }
    }
}

Console.Write("Введите rows: ");
var rows = int.Parse(Console.ReadLine());
Console.Write("Введите cols: ");
var cols = int.Parse(Console.ReadLine());
Console.WriteLine();

if (rows < 1 || cols < 1)
{
    Console.WriteLine("Ошибка! Введите корректные данные");
    return;
}

if (rows != cols)
{
    System.Console.WriteLine("Невозможно");
    return;
}

var arr = GetArray(rows, cols, 1, 100);
PrintArray(arr);
Transp(arr);
Console.WriteLine();
PrintArray(arr);