// 857

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

int[] FlatArray(int[,] arr)
{
    int[] freqArr = new int[arr.Length];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            freqArr[i * arr.GetLength(1) + j] = arr[i, j];
        }
    }

    return freqArr;
}

int[] SortBubbleDerise(int[] array) //void
{
    int temp;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j + 1] > array[j])
            {
                temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}


void PrintFreq(int[] arr)
{
    int k = arr[0];
    int count = 1;

    for (int i = 1; i < arr.Length; i++)
    {
        if (k == arr[i])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{k} встречается {count} раз");
            k = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{k} встречается {count} раз");
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
var flat = FlatArray(arr);
Console.WriteLine(string.Join(", ", flat));
PrintFreq(SortBubbleDerise(flat));
// Freq(arr);
// Console.WriteLine();
//PrintArray(arr);