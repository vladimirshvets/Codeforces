/* 
 * Task 144A
 * 
 * https://codeforces.com/problemset/problem/144/A
 */

// Read the number of soldiers and their heights.
int numberOfSoldiers = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int[] soldierHeights = Array.ConvertAll(separatedInput, h => int.Parse(h));

// Find the lowest and tallest soldiers and their positions.
int minHeight = soldierHeights.Min();
int maxHeight = soldierHeights.Max();
int positionOfLowest = Array.LastIndexOf(soldierHeights, minHeight);
int positionOfTallest = Array.IndexOf(soldierHeights, maxHeight);

// Calculate required time to shift.
int minTimeToShift =
    numberOfSoldiers - 1 - positionOfLowest + positionOfTallest;
if (positionOfLowest < positionOfTallest)
{
    minTimeToShift--;
}

// Write the result.
Console.WriteLine(minTimeToShift);
