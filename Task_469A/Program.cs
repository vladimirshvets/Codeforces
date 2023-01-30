/* 
 * Task 469A
 * 
 * https://codeforces.com/problemset/problem/469/A
 */

// Read the number of levels and the lists of levels passed by each of guys.
int totalNumberOfLevels = int.Parse(Console.ReadLine());

// Collect unique numbers of passed levels.
List<int> passedLevels = new();
for (int i = 0; i < 2; i++)
{
    string input = Console.ReadLine();
    string[] separatedInput = input.Split(' ');
    int numberOfPassedLevels = int.Parse(separatedInput[0]);
    for (int j = 1; j <= numberOfPassedLevels; j++)
    {
        int levelNumber = int.Parse(separatedInput[j]);
        if (!passedLevels.Contains(levelNumber))
        {
            passedLevels.Add(levelNumber);
        }
    }
}

// All levels can be passed if the number of unique levels
// is euqal to the total levels number.
bool canPassAllLevels = passedLevels.Count() == totalNumberOfLevels;

// Write the result.
Console.WriteLine(canPassAllLevels ? "I become the guy." : "Oh, my keyboard!");
