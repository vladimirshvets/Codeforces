/* 
 * Task 1328A
 * 
 * https://codeforces.com/problemset/problem/1328/A
 */

// Read the number of sets.
int numberOfSets = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfSets; i++)
{
    // Read values of divident and divisor.
    string input = Console.ReadLine();
    string[] separatedInput = input.Split(' ');
    int divident = int.Parse(separatedInput[0]);
    int divisor = int.Parse(separatedInput[1]);

    int remainder = divident % divisor;
    int minNumberOfSteps = remainder == 0 ? 0 : divisor - remainder;

    // Write the result.
    Console.WriteLine(minNumberOfSteps);
}
