int[] RandomArray()
{
    int[] arr = new int[8];

    for (int i = 0; i < 8; i++)
        arr[i] = new Random().Next(0, 2);

    return arr;
}


System.Console.WriteLine(string.Join(", ", RandomArray()));

new System.Random().Next()