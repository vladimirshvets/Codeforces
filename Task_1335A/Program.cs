/* 
 * Task 1335A
 * 
 * https://codeforces.com/problemset/problem/1335/A
 */

int numberOfTests = int.Parse(Console.ReadLine());
for (int i = 0; i < numberOfTests; i++)
{
    // Read the value of each test.
    int value = int.Parse(Console.ReadLine());

    // Calculate the number of possible options.
    int numberOfOptions = (value / 2) - (1 - value % 2);

    // Write the result for each test.
    Console.WriteLine(numberOfOptions);
}