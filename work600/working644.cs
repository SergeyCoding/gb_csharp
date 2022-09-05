
class working644
{
    void Fibo(int number)
    {
        int current = 0;
        int next = 1;

        for (int i = 0; i < number; i++)
        {
            Console.Write(current + " ");

            int nextTemp = current + next;
            current = next;
            next = nextTemp;
            // (current, next) = (next, current + next);
        }

    }

    public void Execute()
    {
        Console.Write("Число: ");
        int number = int.Parse(Console.ReadLine());

        Fibo(number);
    }

}
