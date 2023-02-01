/* 
 * Task 510A
 * 
 * https://codeforces.com/problemset/problem/510/A
 */

// Read the dimensions.
string input = Console.ReadLine();
string[] separatedInput = input.Split(' ');
int numberOfRows = int.Parse(separatedInput[0]);
int numberOfColumns = int.Parse(separatedInput[1]);

// Produce the "Snake" matrix.
for (int i = 0; i < numberOfRows; i++)
{
    for (int j = 0; j < numberOfColumns; j++)
    {
        // Even rows that start from 0 are fulfilled with the '#' char.
        if (i % 2 == 0)
        {
            Console.Write('#');
        }
        // Odd rows that start from 0 have the '#' char
        // at the very beginning or at the very end.
        else if ((i % 4 == 1) && (j == numberOfColumns - 1))
        {
            Console.Write('#');
        }
        else if ((i % 4 == 3) && (j == 0))
        {
            Console.Write('#');
        }
        else
        {
            Console.Write('.');
        }
    }
    Console.WriteLine();
}
