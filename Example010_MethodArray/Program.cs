Console.WriteLine("Example 10 MethodArray");

int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };

int find = 41;

int i = 0;

while (i < array.Length)
{
    if (array[i] == find)
    {
        System.Console.WriteLine(i);
        break;
    }
    i++;
}
