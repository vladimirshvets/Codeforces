/* 
 * Task 189A
 * 
 * https://codeforces.com/problemset/problem/189/A 
 */

// Read input values.
int[] input = Array.ConvertAll(
    Console.ReadLine().Split(' '), v => int.Parse(v));

int ribbonLength = input[0];
int[] pieces = input.Skip(1).ToArray();
int maxNumberOfPieces = 0;

// If ai + bj + ck = length,
// then the solution should be Max[i + j + k].
for (int i = 0; i < ribbonLength / pieces[0] + 1; i++)
{
    for (int j = 0; j < ribbonLength / pieces[1] + 1; j++)
    {
        int numberOfPieces = 0;
        int thirdPartLength = ribbonLength - pieces[0] * i - pieces[1] * j;
        switch (thirdPartLength)
        {
            case < 0:
                continue;

            case 0:
                numberOfPieces = i + j;
                break;

            case > 0 when thirdPartLength % pieces[2] == 0:
                numberOfPieces = i + j + thirdPartLength / pieces[2];
                break;
        }

        // Update maximum number.
        if (numberOfPieces > maxNumberOfPieces)
        {
            maxNumberOfPieces = numberOfPieces;
        }
    }
}

// Write the result.
Console.WriteLine(maxNumberOfPieces);
