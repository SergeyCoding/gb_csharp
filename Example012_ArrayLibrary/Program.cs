void FillArray(int[] collection)
{
    int i = 0;
    while (i < collection.Length)
    {
        collection[i] = new Random().Next(1, 10);
        i++;
    }
}

void PrintArray(int[] coll)
{
    int i = 0;
    while (i < coll.Length)
    {
        System.Console.WriteLine(coll[i]);
        i++;
    }
}

Console.WriteLine("Example 12 ArrayLibrary");

int[] array = new int[10];

FillArray(array);
PrintArray(array);
