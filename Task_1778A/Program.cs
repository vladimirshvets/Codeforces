/* 
 * Task 1778A
 * 
 * https://codeforces.com/problemset/problem/1778/A
 */

// Read the number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    // Read the sequence.
    int sequenceLength = int.Parse(Console.ReadLine());
    string input = Console.ReadLine();
    string[] separatedInput = input.Split(' ');
    int[] sequence = Array.ConvertAll(separatedInput, v => int.Parse(v));

    // Calculate the summ of sequence and
    // amount of positive and negative elements.
    bool hasTwoNegativeInARow = false;
    int summOfValues = sequence[0];
    int numberOfPositive = sequence[0] > 0 ? 1 : 0;
    for (int j = 1; j < sequenceLength; j++)
    {
        if (sequence[j] > 0)
        {
            numberOfPositive++;
        }
        else if (sequence[j - 1] < 0)
        {
            hasTwoNegativeInARow = true;
        }
        summOfValues += sequence[j];
    }

    // Write the result.
    if (hasTwoNegativeInARow)
    {
        // Update "-1 -1" to "1 1" if possible.
        Console.WriteLine(summOfValues + 4);
    }
    else if (numberOfPositive == sequenceLength)
    {
        // Positive values only, have to update "1 1" to "-1 -1".
        Console.WriteLine(summOfValues - 4);
    }
    else
    {
        // Update "-1 1" to "1 -1" or vice versa to get the same summ.
        Console.WriteLine(summOfValues);
    }
}
