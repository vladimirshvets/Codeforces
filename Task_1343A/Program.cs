/* 
 * Task 1343A
 * 
 * https://codeforces.com/problemset/problem/1343/A
 */

// Read the number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

// Note:
// (2^k - 1) * x = n
// 2^30 - 1 > 10^9
int[] divisors = new int[30];
for (int i = 2; i < 30; i++)
{
    divisors[i] = (int)Math.Pow(2, i) - 1;
}

for (int i = 0; i < numberOfTests; i++)
{
    int numberOfWrappers = int.Parse(Console.ReadLine());
    int divisor = 0;
    for (int j = 2; j < 30; j++)
    {
        if (numberOfWrappers % divisors[j] == 0)
        {
            divisor = divisors[j];
            break;
        }
    }

    // Write the result.
    Console.WriteLine(numberOfWrappers / divisor);
}
