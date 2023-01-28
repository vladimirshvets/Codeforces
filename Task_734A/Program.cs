/* 
 * Task 734A
 * 
 * https://codeforces.com/problemset/problem/734/A 
 */

int numberOfGames = int.Parse(Console.ReadLine());

// Read the game results string.
string input = Console.ReadLine();

// Count all the 'A' chars.
int numberOfAntonWins = 0;
foreach (var c in input)
{
    if (c.Equals('A'))
    {
        numberOfAntonWins++;
    }
}

// Write the result.
switch (numberOfAntonWins.CompareTo(input.Length - numberOfAntonWins))
{
    case > 0:
        Console.WriteLine("Anton");
        break;
    case < 0:
        Console.WriteLine("Danik");
        break;
    default:
        Console.WriteLine("Friendship");
        break;
}
