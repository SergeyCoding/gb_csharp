// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
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

int IndexOf(int[] arr, int find)
{
    int i = 0;
    while (i < arr.Length)
    {
        if (find == arr[i])
        {
            return i;
        }
        i++;
    }

    return -1;
}

Console.WriteLine("Example 12 ArrayLibrary");

int[] array = new int[10];

FillArray(array);
PrintArray(array);
var res = IndexOf(array, 4);

System.Console.WriteLine(res);
