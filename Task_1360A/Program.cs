/* 
 * Task 1360A
 * 
 * https://codeforces.com/problemset/problem/1360/A
 */

// Read the number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    // Read the sizes of rectangle.
    int[] sizes =
        Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));

    // Calculate the square.
    double result = Math.Pow(Math.Max(sizes.Max(), sizes.Min() * 2), 2);

    // Write the result.
    Console.WriteLine(result);
}
