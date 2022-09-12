// 859

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

int[,] DeleteMinElement(int[,] arr)
{

    int min = arr[0, 0];
    int curRow = 0;
    int curCol = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (min > arr[i, j])
            {
                min = arr[i, j];
                curRow = i;
                curCol = j;
            }
        }
    }

    int[,] result = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i == curRow)
            continue;

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == curCol)
                continue;

            result[i < curRow ? i : i - 1, j < curCol ? j : j - 1] = arr[i, j];
        }
    }

    return result;
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

var arr = GetArray(rows, cols, 1, 3);
PrintArray(arr);
Console.WriteLine();
PrintArray(DeleteMinElement(arr));
