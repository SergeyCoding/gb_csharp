class PictureExample
{
    int[,] pic = new int[,]
     {
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
     };

    void PrintImage(int[,] image)
    {
        for (int i = 0; i < image.GetLength(0); i++)
        {
            for (int j = 0; j < image.GetLength(1); j++)
            {
                if (image[i, j] == 0) Console.Write($" ");
                else Console.Write($"+");
            }
            Console.WriteLine();
        }
    }


    void FillImage(int row, int col)
    {
        if (row < 0 || col < 0 || row >= pic.GetLength(0) || col >= pic.GetLength(1) || pic[row, col] == 1)
            return;

        pic[row, col] = 1;

        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }

    void FillImageCycle(int rowInit, int colInit)
    {
        int[] rows = new int[1000];
        int[] cols = new int[1000];

        var stack = new Stack<(int row, int col)>();

        var count = 0;
        rows[count] = rowInit;
        cols[count] = colInit;
        stack.Push((rowInit, colInit));

        while (count >= 0)
        {
            int row = rows[count];
            int col = cols[count];
            count--;

            if (row < 0 || col < 0 || row >= pic.GetLength(0) || col >= pic.GetLength(1) || pic[row, col] == 1)
                continue;

            pic[row, col] = 1;

            // FillImage(row - 1, col);
            count++;
            rows[count] = row - 1;
            cols[count] = col;

            // FillImage(row, col - 1);
            count++;
            rows[count] = row;
            cols[count] = col - 1;

            // FillImage(row + 1, col);
            count++;
            rows[count] = row + 1;
            cols[count] = col;

            // FillImage(row, col + 1);
            count++;
            rows[count] = row;
            cols[count] = col + 1;
        }
    }

    void FillImageStackCycle(int rowInit, int colInit)
    {
        var stack = new Stack<(int row, int col)>();

        stack.Push((rowInit, colInit));

        while (stack.Any())
        {
            (int row, int col) = stack.Pop();

            if (row < 0 || col < 0 || row >= pic.GetLength(0) || col >= pic.GetLength(1) || pic[row, col] == 1)
                continue;

            pic[row, col] = 1;

            stack.Push((row - 1, col));
            stack.Push((row, col - 1));
            stack.Push((row + 1, col));
            stack.Push((row, col + 1));
        }
    }

    public void Execute()
    {
        // PrintImage(pic);

        //FillImage(14, 13);
        FillImageStackCycle(13, 13);
        PrintImage(pic);
    }
}