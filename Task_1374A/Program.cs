/* 
 * Task 1374A
 * 
 * https://codeforces.com/problemset/problem/1374/A
 */

// Read the number of tests and tests themselves.
int numberOfTests = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfTests; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    int x = int.Parse(input[0]);
    int y = int.Parse(input[1]);
    int n = int.Parse(input[2]);

    int nearestDividend = n / x * x;
    int result = nearestDividend + y;
    if (result > n)
    {
        result -= x;
    }

    // Write the result.
    Console.WriteLine(result);
}
