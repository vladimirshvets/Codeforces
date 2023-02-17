/* 
 * Task 703A
 * 
 * https://codeforces.com/problemset/problem/703/A
 */

// Read the number of rounds.
int numberOfRounds = int.Parse(Console.ReadLine());

int winsOfMishka = 0;
int winsOfChris = 0;

// Count wins based on the round results.
for (int i = 0; i < numberOfRounds; i++)
{
    int[] input =
        Array.ConvertAll(Console.ReadLine().Split(' '), v => int.Parse(v));
    if (input[0] > input[1])
    {
        winsOfMishka++;
    }
    else if (input[0] < input[1])
    {
        winsOfChris++;
    }
}

// Write the result.
switch (winsOfMishka.CompareTo(winsOfChris))
{
    case 1:
        Console.WriteLine("Mishka");
        break;

    case -1:
        Console.WriteLine("Chris");
        break;

    case 0:
        Console.WriteLine("Friendship is magic!^^");
        break;
}
