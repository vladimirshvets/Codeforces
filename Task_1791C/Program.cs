/* 
 * Task 1791C
 * 
 * https://codeforces.com/problemset/problem/1791/C
 */

// Read the number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

// For each test proceed with the string.
for (int i = 0; i < numberOfTests; i++)
{
    // Read the binary string and its length.
    int finalStringLength = int.Parse(Console.ReadLine());
    string finalString = Console.ReadLine();

    int numberOfModifications = 0;
    for (int j = 0; j < finalStringLength / 2; j++)
    {
        if (finalString[j] != finalString[finalStringLength - 1 - j])
        {
            numberOfModifications++;
        }
        else
        {
            break;
        }
    }

    // Write the result.
    int sourceStringLength = finalStringLength - numberOfModifications * 2;
    Console.WriteLine(sourceStringLength);
}
