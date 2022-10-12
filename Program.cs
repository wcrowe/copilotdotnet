// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
//Fib(10).dump();
var fibme = 10;
Console.WriteLine($"Fib of {fibme} is {Numbers.Fib(fibme)}");
// Language: csharp

var primeme = 5394;
Console.WriteLine($"Largest prime of {primeme} is {Numbers.GetBiggestPrime(primeme)}");
public class Numbers {
// method to calculate fibonacci numbers with memoization
 public   static int Fib(int n) {
        int[] memo = new int[n + 1];
        return Fib(n, memo);
    }

    static int Fib(int n, int[] memo) {
        if (memo[n] != 0) {
            return memo[n];
        }

        if (n == 1 || n == 2) {
            return 1;
        }

        memo[n] = Fib(n - 1, memo) + Fib(n - 2, memo);
        return memo[n];
    }

// method get the biggest prime number
    public  static int GetBiggestPrime(int n) {
        int biggestPrime = 0;
        for (int i = 2; i <= n; i++) {
            if (n % i == 0) {
                biggestPrime = i;
                n /= i;
                i--;
            }
        }

        return biggestPrime;
    }
}