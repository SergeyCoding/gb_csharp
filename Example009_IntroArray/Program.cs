Console.WriteLine("Example 09 IntroArray");

int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };

var max1 = Max(array[0], array[1], array[2]);
var max2 = Max(array[3], array[4], array[5]);
var max3 = Max(array[6], array[7], array[8]);

var result = Max(max1, max2, max3);

Console.WriteLine(result);

int Max(int a, int b, int c)
{
    int res = a;
    if (res < b) res = b;
    if (res < c) res = c;
    return res;
}

