// 861

void PrintArray(int[] array, int tab)
{
    Console.Write(new string('\t', tab));
    System.Console.WriteLine(string.Join("\t\t", array));
}

int[] PascalTriangleNext(int[] arr)
{
    if (arr == null)
        return new[] { 1, 1 };

    var result = new int[arr.Length + 1];
    result[0] = 1;
    result[result.Length - 1] = 1;

    for (int i = 1; i < result.Length - 1; i++)
        result[i] = arr[i - 1] + arr[i];

    return result;
}



Console.Write("Количество строк: ");
var number = int.Parse(Console.ReadLine());
Console.WriteLine();

if (number < 1)
{
    Console.WriteLine("Ошибка! Введите корректные данные");
    return;
}

var pt = PascalTriangleNext(null);
for (int i = 1; i <= number; i++)
{
    PrintArray(pt, number - i);
    pt = PascalTriangleNext(pt);
}