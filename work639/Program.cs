int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void Reverse(int[] arr)
{
    int first = 0;
    int last = arr.Length - 1;

    while (first < last)
    {
        (arr[first], arr[last]) = (arr[last], arr[first]);
        first++;
        last--;
    }
}

Console.Write("Размер массива: ");
int number = int.Parse(Console.ReadLine());

int[] myArray = GetArray(number, 1, 10);
Console.WriteLine(string.Join(", ", myArray));
Reverse(myArray);
Console.WriteLine(string.Join(", ", myArray));