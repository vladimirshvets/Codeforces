/* 
 * Task 1475A
 * 
 * https://codeforces.com/problemset/problem/1475/A
 */

// Read the number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    long value = long.Parse(Console.ReadLine());

    // Write the result.
    // Note: values that are power of two don't have odd divisors.
    Console.WriteLine((value & (value - 1)) == 0 ? "NO" : "YES");
}
