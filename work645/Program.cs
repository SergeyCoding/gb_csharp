int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] CopyArray(int[] arr)
{

    int[] result = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i];
    }

    return result;
}

Console.Write("Размер массива: ");
int number = int.Parse(Console.ReadLine());

int[] myArray = GetArray(number, 1, 10);
Console.WriteLine(string.Join(", ", myArray));
int[] copiedArray = CopyArray(myArray);
Console.WriteLine(string.Join(", ", copiedArray));