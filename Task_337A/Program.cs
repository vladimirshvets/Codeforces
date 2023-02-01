/* 
 * Task 337A
 * 
 * https://codeforces.com/problemset/problem/337/A
 */

// Read the number of students and number of available puzzles.
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int numberOfStudents = int.Parse(separatedInput[0]);
int numberOfPuzzles = int.Parse(separatedInput[1]);

// Read sizes of puzzles.
input = Console.ReadLine();
separatedInput = input.Split(' ');
int[] puzzleSizes = Array.ConvertAll(separatedInput, s => int.Parse(s));

Array.Sort(puzzleSizes);
int minSizeOffset = puzzleSizes[numberOfPuzzles - 1] - puzzleSizes[0];
for (int i = 0; i <= numberOfPuzzles - numberOfStudents; i++)
{
    int sizeOffset = puzzleSizes[i + numberOfStudents - 1] - puzzleSizes[i];
    if (sizeOffset < minSizeOffset)
    {
        minSizeOffset = sizeOffset;
    }
}

// Write the result.
Console.WriteLine(minSizeOffset);
