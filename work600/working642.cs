#pragma warning disable CS0162



class working642
{

    string ToBinary(int number)
    {
        if (number == 0) return "0";
        if (number == 1) return "1";
        return ToBinary(number / 2) + number % 2;
    }

    public void Execute()
    {
        Console.Write("Число: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(ToBinary(number));
    }
}
