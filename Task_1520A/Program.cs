/* 
 * Task 1520A
 * 
 * https://codeforces.com/problemset/problem/1520/A
 */

// Read the number of tests.
int numberOfTests = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfTests; i++)
{
    // Read the number of days and task names.
    byte numberOfDays = byte.Parse(Console.ReadLine());
    string tasks = Console.ReadLine();

    // Check if the current task was solved sometime later.
    bool isHonest = true;
    byte j = 0;
    while (j < tasks.Length)
    {
        byte k = j;
        while (k < tasks.Length && tasks[j] == tasks[k])
        {
            k++;
        }

        if (tasks.Substring(k).Contains(tasks[j]))
        {
            isHonest = false;
            break;
        }
        j = k;
    }

    // Write the result.
    Console.WriteLine(isHonest ? "YES" : "NO");
}
