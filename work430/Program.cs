int[] RandomArray()
{
    int[] arr = new int[8];

    for (int i = 0; i < 8; i++)
        arr[i] = new Random().Next(0, 2);

    return arr;
}

void PrintArray(int[] coll)
{
    int i = 0;
    while (i < coll.Length)
    {
        System.Console.Write($"{coll[i]} ");
        i++;
    }
}

PrintArray(RandomArray());
