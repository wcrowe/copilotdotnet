// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Fib(10).dump();

// Language: csharp


// method to calculate fibonacci numbers with memoization
public static int Fib(int n)
{
    int[] memo = new int[n + 1];
    return Fib(n, memo);
}
static int Fib(int n, int[] memo)
{
    if (memo[n] != 0)
    {
        return memo[n];
    }
    if (n == 1 || n == 2)
    {
        return 1;
    }
    memo[n] = Fib(n - 1, memo) + Fib(n - 2, memo);
    return memo[n];
}

// method get the biggest prime number
public static int GetBiggestPrime(int n)
{
    int biggestPrime = 0;
    for (int i = 2; i <= n; i++)
    {
        if (n % i == 0)
        {
            biggestPrime = i;
            n /= i;
            i--;
        }
    }
    return biggestPrime;
}