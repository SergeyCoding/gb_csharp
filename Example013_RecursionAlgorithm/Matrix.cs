public class Matrix
{
    private readonly int[,] matrix;

    public Matrix(int[,] matrix)
    {
        this.matrix = matrix;
    }

    public void PrintArray()
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                System.Console.Write($"{matrix[row, col],10} ");
            }

            System.Console.WriteLine();
        }
    }

    public int[,] FillArray(int minValue, int maxValue)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = new Random().Next(minValue, maxValue);
            }
        }

        return matrix;
    }


}

