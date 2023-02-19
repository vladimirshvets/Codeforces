/* 
 * Task 1360B
 * 
 * https://codeforces.com/problemset/problem/1360/B
 */

// Read the number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    // Read the number of athletes and their power values.
    int numberOfAthletes = int.Parse(Console.ReadLine());
    int[] powers =
        Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));

    // Sort the values and compare each pair of nearly placed values.
    Array.Sort(powers);
    int minDifference = int.MaxValue;
    for (int j = 0; j < numberOfAthletes - 1; j++)
    {
        if (powers[j + 1] - powers[j] < minDifference)
        {
            minDifference = powers[j + 1] - powers[j];
        }
    }

    // Write the result.
    Console.WriteLine(minDifference);
}
