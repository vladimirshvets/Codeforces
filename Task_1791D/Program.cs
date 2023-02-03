/* 
 * Task 1791D
 * 
 * https://codeforces.com/problemset/problem/1791/D
 */

// Read the number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

// For each test proceed with the string.
for (int i = 0; i < numberOfTests; i++)
{
    // Read the string and its length.
    int testStringLength = int.Parse(Console.ReadLine());
    string testString = Console.ReadLine();

    // Initialize the storages.
    List<char> uniqueCharsForward = new();
    List<char> uniqueCharsBackward = new();
    int[] numberOfUniqueCharsForward = new int[testStringLength];
    int[] numberOfUniqueCharsBackward = new int[testStringLength];
    bool isMaximumReached = false;

    // Cover edge cases.
    numberOfUniqueCharsForward[0] = 1;
    uniqueCharsForward.Add(testString[0]);
    numberOfUniqueCharsBackward[testStringLength - 1] = 1;
    uniqueCharsBackward.Add(testString[testStringLength - 1]);

    for (int j = 1, k = testStringLength - 2; j < testStringLength - 1; j++, k--)
    {
        // Determine what number of unique chars contains in the substring
        // going forward from the string start.
        numberOfUniqueCharsForward[j] =
                numberOfUniqueCharsForward[j - 1];
        if (!uniqueCharsForward.Contains(testString[j]))
        {
            numberOfUniqueCharsForward[j]++;
            uniqueCharsForward.Add(testString[j]);
        }

        // Determine what number of unique chars contains in the substring
        // going backward from the string end.
        numberOfUniqueCharsBackward[k]
            = numberOfUniqueCharsBackward[k + 1];
        if (!uniqueCharsBackward.Contains(testString[k]))
        {
            numberOfUniqueCharsBackward[k]++;
            uniqueCharsBackward.Add(testString[k]);
        }

        // If both substrings, counting from the beginning and from the end,
        // have all possible unique chars, there is no need to continue,
        // the answer will be 52 anyway.
        if (numberOfUniqueCharsForward[j] == 26 &&
            numberOfUniqueCharsBackward[k] == 26)
        {
            isMaximumReached = true;
            break;
        }
    }

    // Partial case: the string can be divided into two substrings that contain
    // all possible unique chars (26 + 26).
    if (isMaximumReached)
    {
        Console.WriteLine(52);
    }
    else
    {
        // Compare all combinations to find optimal solution.
        int maxSumm =
            numberOfUniqueCharsForward[0] + numberOfUniqueCharsBackward[1];
        for (int j = 1; j < testStringLength - 1; j++)
        {
            int currentSumm = numberOfUniqueCharsForward[j] +
                numberOfUniqueCharsBackward[j + 1];
            if (currentSumm > maxSumm)
            {
                maxSumm = currentSumm;
            }
        }

        // Write the result.
        Console.WriteLine(maxSumm);
    }
}
