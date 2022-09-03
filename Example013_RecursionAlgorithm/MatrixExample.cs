class MatrixExample
{
    public static void Execute()
    {
        int[,] matrix = new int[2, 5];

        var m = new Matrix(matrix);

        m.PrintArray();
        m.FillArray(1, 10);
        Console.WriteLine();
        m.PrintArray();
    }
}

