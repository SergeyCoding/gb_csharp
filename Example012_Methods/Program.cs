#pragma warning disable CS8321
// Вид 1
using Example012;

void Method1()
{
    Console.WriteLine("");
}

Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Text");

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
Console.WriteLine(Method3());

// Вид 3
string Method4(Int16 count, char c)
{
    string result = string.Join('-', c);
    return result;
}

Method4(10, '*');


// for
for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.Write(i * j + " ");
    }
    Console.WriteLine();
}

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

PrintArray(arr);

void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPos = i;

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPos])
            {
                minPos = j;
            }
        }

        int temp = arr[i];
        arr[i] = arr[minPos];
        arr[minPos] = temp;
    }
}

SelectionSort(arr);
PrintArray(arr);

Console.WriteLine(new PrintArray2(arr));
