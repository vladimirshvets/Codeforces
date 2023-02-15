/* 
 * Task 1512A
 * 
 * https://codeforces.com/problemset/problem/1512/A
 */

// Read number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    int numberOfValues = int.Parse(Console.ReadLine());
    int[] values =
        Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));

    // Get unique value from the sequence and write it.
    foreach (int unique in values.Distinct())
    {
        if (values.Count(v => v == unique) == 1)
        {
            Console.WriteLine(Array.IndexOf(values, unique) + 1);
            break;
        }
    }
}
