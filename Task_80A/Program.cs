/* 
 * Task 80A
 * 
 * https://codeforces.com/problemset/problem/80/A 
 */

string[] input = Console.ReadLine().Split(' ');
int numberOne = int.Parse(input[0]);
int numberTwo = int.Parse(input[1]);

List<int> primes = GetPrimeNumbers(53);
int indexOfOne = primes.IndexOf(numberOne);
if (primes[indexOfOne + 1] == numberTwo)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}


List<int> GetPrimeNumbers(long upTo)
{
    // Using the "Sieve of Eratosthenes" approach.
    bool[] sieve = new bool[upTo + 1];

    for (int i = 2; i * i <= upTo; i++)
    {
        if (!sieve[i])
        {
            for (int j = i * i; j <= upTo; j += i)
            {
                sieve[j] = true;
            }
        }
    }

    // Produce a collection of prime numbers.
    List<int> primes = new();
    for (int i = 2; i <= upTo; i++)
    {
        if (!sieve[i])
        {
            primes.Add(i);
        }
    }

    return primes;
}
