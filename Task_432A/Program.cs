/* 
 * Task 432A
 * 
 * https://codeforces.com/problemset/problem/432/A
 */

// Read number of guys and number of future rounds.
int[] input =
    Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));
int numberOfGuys = input[0];
int numberOfRounds = input[1];

// Read number of passed rounds per each guy.
input = Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));

// Check how many guys can participate in the future.
int shortlistedGuys = 0;
for (int i = 0; i < numberOfGuys; i++)
{
    if (input[i] + numberOfRounds <= 5)
    {
        shortlistedGuys++;
    }
}

// Write the result.
Console.WriteLine(shortlistedGuys / 3);
