/* 
 * Task 1367B
 * 
 * https://codeforces.com/problemset/problem/1367/B
 */

// Read the number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    // Read the number of values and values themselves.
    int numberOfValues = int.Parse(Console.ReadLine());
    int[] values =
        Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));

    // Calculate the number of "good" positions.
    // If the position isn't "good", store the number of even and odd values.
    int numberOfGoodPositions = 0;
    int numberOfEvenValues = 0;
    int numberOfOddValues = 0;
    for (int j = 0; j < numberOfValues; j++)
    {
        if (values[j] % 2 == j % 2)
        {
            numberOfGoodPositions++;
        }
        else if (values[j] % 2 == 0)
        {
            numberOfEvenValues++;
        }
        else
        {
            numberOfOddValues++;
        }
    }

    // Write the result.
    if ((numberOfValues - numberOfGoodPositions) % 2 == 0 &&
        numberOfEvenValues == numberOfOddValues)
    {
        Console.WriteLine((numberOfValues - numberOfGoodPositions) / 2);
    }
    else
    {
        Console.WriteLine(-1);
    }
}
