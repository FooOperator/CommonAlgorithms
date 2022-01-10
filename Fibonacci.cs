/**/// See https://aka.ms/new-console-template for more information
public class Fibonacci
{
    public static uint GetNthFibonacci(uint nth)
    {
        return nth <= 1 ? 1 : GetNthFibonacci(nth - 1) + GetNthFibonacci(nth - 2);
    }

    public static uint[] GetFibonacciUntil(uint end)
    {
        uint[] fibs = new uint[end + 1];

        for (uint i = 0; i < end + 1; i++)
        {
            fibs[i] = GetNthFibonacci(i);
        }

        return fibs;
    }
}