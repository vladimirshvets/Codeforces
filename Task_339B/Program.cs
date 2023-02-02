/* 
 * Task 339B
 * 
 * https://codeforces.com/problemset/problem/339/B
 */

// Read the number of buildings and the number of doings.
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int numberOfBuildings = int.Parse(separatedInput[0]);
int numberOfDoings = int.Parse(separatedInput[1]);

// Read the coordinates of buildings linked to each doing.
input = Console.ReadLine();
separatedInput = input.Split(' ');
int[] doings = Array.ConvertAll(separatedInput, b => int.Parse(b));

// Calculate time periods between each pair of nearby doings.
long totalTime = doings[0] - 1;
for (int i = 1; i < numberOfDoings; i++)
{
    if (doings[i] >= doings[i - 1])
    {
        totalTime += doings[i] - doings[i - 1];
    }
    else
    {
        totalTime += numberOfBuildings - doings[i - 1] + doings[i];
    }
}

// Write the result.
Console.WriteLine(totalTime);
