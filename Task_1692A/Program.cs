/* 
 * Task 1692A
 * 
 * https://codeforces.com/problemset/problem/1692/A
 */

// Read the number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    // Read the distances.
    int[] distances =
        Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));
    int distanceOfTimur = distances[0];

    // Count the runners who ran longer distances than Timur.
    int shortlist = (from d in distances
                     where d > distanceOfTimur
                     select d).Count();

    // Write the result.
    Console.WriteLine(shortlist);
}
