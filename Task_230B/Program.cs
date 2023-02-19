/* 
 * Task 230B
 * 
 * https://codeforces.com/problemset/problem/230/B
 */

internal class Program
{
    private static readonly long s_maxPrimeValue = 1000000;

    private static void Main(string[] args)
    {
        // Read the number of tests and test values themselves.
        int numberOfTests = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string[] separatedInput = input.Split(' ');

#if DEBUG
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();
#endif

        // Note: square of a prime number can meet the requirements only.
        // So we need to collect all prime numbers up to 10^6
        // and retrieve their squares then.
        IEnumerable<long> primeSquares = GetPrimeNumberSquares(s_maxPrimeValue);

        // Proceed with each test.
        for (int i = 0; i < numberOfTests; i++)
        {
            // Parse the positive number (up to 10^12).
            long value = long.Parse(separatedInput[i]);

            // Determine whether the specified value is T-Prime or not.
            Console.WriteLine(primeSquares.Contains(value) ? "YES" : "NO"); 
        }

#if DEBUG
        watch.Stop();
        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
#endif
    }

    /// <summary>
    /// Produces the primes' squares. 
    /// </summary>
    /// <param name="maxPrime">Maximum prime number value</param>
    /// <returns>The collection of squares of prime numbers.</returns>
    private static IEnumerable<long> GetPrimeNumberSquares(long maxPrime)
    {
        // Using the "Sieve of Eratosthenes" approach.
        bool[] sieve = new bool[maxPrime + 1];

        for (long i = 2; i * i <= maxPrime; i++)
        {
            if (!sieve[i])
            {
                for (long j = i * i; j <= maxPrime; j += i)
                {
                    sieve[j] = true;
                }
            }
        }

        // Produce a list of squares based on prime numbers.
        HashSet<long> primeSquares = new();
        for (long i = 2; i <= maxPrime; i++)
        {
            if (!sieve[i])
            {
                primeSquares.Add(i * i);
            }
        }

        return primeSquares;
    }
}
