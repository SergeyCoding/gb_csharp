
class working639
{

    void Reverse(int[] arr)
    {
        int first = 0;
        int last = arr.Length - 1;

        while (first < last)
        {
            (arr[first], arr[last]) = (arr[last], arr[first]);
            first++;
            last--;
        }
    }

    public void Execute()
    {
        //int[] arr = { 1, 2, 3, 4, 5 };
        int[] arr = { 6, 7, 3, 6 };

        Reverse(arr);

        Console.WriteLine(string.Join(", ", arr));
    }
}
