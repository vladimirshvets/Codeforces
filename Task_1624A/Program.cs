/* 
 * Task 1624A
 * 
 * https://codeforces.com/problemset/problem/1624/A
 */

// Read the number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    // Read the number of values and values themselves.
    int numberOfValues = int.Parse(Console.ReadLine());
    int[] values =
        Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));

    // Write the result.
    Console.WriteLine(values.Max() - values.Min());
}
