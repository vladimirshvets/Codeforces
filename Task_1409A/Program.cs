/* 
 * Task 1409A
 * 
 * https://codeforces.com/problemset/problem/1409/A
 */

// Read number of tests.
int numberOfTests = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfTests; i++)
{
    // Read two numbers.
    string input = Console.ReadLine();
    string[] separatedInput = input.Split(' ');
    int first = int.Parse(separatedInput[0]);
    int second = int.Parse(separatedInput[1]);

    // Find the difference and cover it with summands of tens.
    int difference = Math.Max(first, second) - Math.Min(first, second);
    int result = difference / 10;

    // If there is still some difference, cover it with one summand of 1..9.
    if (difference % 10 > 0)
    {
        result++;
    }

    // Write result.
    Console.WriteLine(result);
}
