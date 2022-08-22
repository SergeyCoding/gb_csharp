Console.WriteLine("Example 09 IntroArray");

int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };

array[0] = 12;

System.Console.WriteLine(array[0]);

int Max(int a, int b, int c)
{
    int res = a;
    if (res < b) res = b;
    if (res < c) res = c;
    return res;
}

