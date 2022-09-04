class FactorialExample
{
    double Factorial(int n)
    {
        // 1! = 1
        // 0! = 1
        if (n == 0) return 1;
        else return n * Factorial(n - 1);
    }

    public void Execute()
    {
        Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6
    }
}

