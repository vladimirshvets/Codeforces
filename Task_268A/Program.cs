/* 
 * Task 268A
 * 
 * https://codeforces.com/problemset/problem/268/A
 */

// Read the number of teams and their home and away match colors.
int numberOfTeams = int.Parse(Console.ReadLine());
var homeMatchColors = new int[numberOfTeams];
var awayMatchColors = new int[numberOfTeams];
for (int i = 0; i < numberOfTeams; i++)
{
    string input = Console.ReadLine();
    string[] separatedInput = input.Split(' ');
    homeMatchColors[i] = int.Parse(separatedInput[0]);
    awayMatchColors[i] = int.Parse(separatedInput[1]);
}

// Determine the cases when teams are forced to change their color.
int numberOfColorChanges = 0;
for (int i = 0; i < numberOfTeams; i++)
{
    int numberOfTeamsWithSameColor = 0;
    for (int j = 0; j < numberOfTeams; j++)
    {
        if (homeMatchColors[i] == awayMatchColors[j])
        {
            numberOfTeamsWithSameColor++;
        }
    }
    numberOfColorChanges += numberOfTeamsWithSameColor;
}

// Write the result.
Console.WriteLine(numberOfColorChanges);
