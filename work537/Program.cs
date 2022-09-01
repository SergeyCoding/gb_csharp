// 537

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] Proizv(int[] arr)
{
    int[] result = new int[arr.Length / 2 + arr.Length % 2];
    int first = 0;
    int last = arr.Length - 1;

    while (first < last)
    {
        result[first] = arr[first] * arr[last];
        first++;
        last--;
    }

    if (first == last)
        result[first] = arr[first];

    return result;
}

int[] ProductionArray(int[] array)
{
    int size = array.Length / 2;

    if (array.Length % 2 != 0) size++;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0) result[size - 1] = array[array.Length / 2];
    return result;

}

// если поставить диапазон от 10 до 99, тогда все попадут
int[] myArray = GetArray(10, -10, 100);
// myArray = new int[] { 1, 2 };
Console.WriteLine(String.Join(" ", myArray));


Console.WriteLine(String.Join(" ", Proizv(myArray)));
Console.WriteLine(String.Join(" ", ProductionArray(myArray)));