namespace Example012;


class PrintArray2
{
    private readonly int[] arr;

    public PrintArray2(int[] arr)
    {
        this.arr = arr;
    }

    public override string ToString()
    {

        return string.Join(", ", arr);
    }
}