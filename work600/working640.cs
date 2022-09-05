class working640
{
    bool IsExistTriangle(int[] arr)
    {

        var max = arr.OrderByDescending(x => x).ToArray();

        foreach (var item in arr)
        {
            if (item <= 0)
                return false;
        }



        return max[0] < max[1] + max[2];
    }

    public void Execute()
    {
        // Console.Write("Число: ");
        // int number = int.Parse(Console.ReadLine());

        int b = 10;
        int a = 8;
        int c = 2;

        if (IsExistTriangle(new int[] { a, b, c }))
            Console.WriteLine("да");
        else
            Console.WriteLine("нет");

    }
}