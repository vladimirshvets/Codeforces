/* 
 * Task 1343B
 * 
 * https://codeforces.com/problemset/problem/1343/V
 */

using System.Text;

// Read number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    int value = int.Parse(Console.ReadLine());
    if (value % 4 == 0)
    {
        // Build the sequence.
        var sequence = new StringBuilder();
        for (int j = 2; j <= value; j += 2)
        {
            sequence.Append($"{j} ");
        }
        for (int j = 1; j <= value - 3; j += 2)
        {
            sequence.Append($"{j} ");
        }
        sequence.Append(value * 3 / 2 - 1);

        // Write the result.
        Console.WriteLine("YES");
        Console.WriteLine(sequence.ToString());
    }
    else
    {
        Console.WriteLine("NO");
    }
}
