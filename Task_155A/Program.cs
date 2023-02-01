/* 
 * Task 155A
 * 
 * https://codeforces.com/problemset/problem/155/A 
 */

// Read the number of competitions and their results.
int numberOfCompetitions = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int[] competitionResults = Array.ConvertAll(separatedInput, r => int.Parse(r));

// Calculate the number of amazing results.
int absoluteMinimum = competitionResults[0];
int absoluteMaximum = competitionResults[0];
int numberOfAmazingResults = 0;
for (int i = 1; i < numberOfCompetitions; i++)
{
    if (competitionResults[i] < absoluteMinimum)
    {
        absoluteMinimum = competitionResults[i];
        numberOfAmazingResults++;
    }
    else if (competitionResults[i] > absoluteMaximum)
    {
        absoluteMaximum = competitionResults[i];
        numberOfAmazingResults++;
    }
}

// Write the number of amazing results.
Console.WriteLine(numberOfAmazingResults);
