class StringArrayExample
{

    public StringArrayExample()
    {

    }

    public void Execute()
    {
        // row-column
        string[,] table = new string[2, 5];

        table[1, 2] = "word";

        for (int row = 0; row < 2; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                Console.Write($"-{table[row, col],10}- ");
            }
            Console.WriteLine();
        }
    }
}

