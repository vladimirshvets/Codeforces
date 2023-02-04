/* 
 * Task 1352A
 * 
 * https://codeforces.com/problemset/problem/1352/A
 */

// Read the number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

// Search the solution for each test.
for (int i = 0; i < numberOfTests; i++)
{
    // Read the test value as string.
    string testValue = Console.ReadLine();

    // Produce an addend for every non-zero digit.
    List<string> addends = new();
    for (int j = 0; j < testValue.Length; j++)
    {
        if (testValue[j] != '0')
        {
            string addend =
                $"{testValue[j]}".PadRight(testValue.Length - j, '0');
            addends.Add(addend);
        }
    }

    // Write the result.
    Console.WriteLine(addends.Count);
    Console.WriteLine(string.Join(' ', addends));
}
