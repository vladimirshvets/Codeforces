/* 
 * Task 1367A
 * 
 * https://codeforces.com/problemset/problem/1367/A
 */

using System.Text;

// Read number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    // Build the source string based on modified.
    string modified = Console.ReadLine();
    var source = new StringBuilder();
    source.Append(modified.First());
    for (int j = 1; j < modified.Length - 1; j += 2)
    {
        source.Append(modified[j]);
    }
    source.Append(modified.Last());

    // Write the result.
    Console.WriteLine(source.ToString());
}
